// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Encodings.Web;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Overclock3D.Database;

var sw = Stopwatch.StartNew();

DotNetEnv.Env.TraversePath().Load();

var serviceCollection = new ServiceCollection();

var connectionString = DotNetEnv.Env.GetString("OVERCLOCK_CONNECTION_STRING");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));

serviceCollection.AddDbContext<OverclockContext>(builder =>
    builder
        .UseMySql(connectionString, serverVersion)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

var serviceProvider = serviceCollection.BuildServiceProvider();

var overclockContext = serviceProvider.GetRequiredService<OverclockContext>();

var exportPath = DotNetEnv.Env.GetString("OVERCLOCK_EXPORT_PATH");
if (Directory.Exists(exportPath)) Directory.Delete(exportPath, true);

var contents = overclockContext.Tblcontents
    .Include(c => c.TableContentData);

Dictionary<string, List<DocInfo>> map = new();

foreach (var content in contents)
{
    if (string.IsNullOrWhiteSpace(content.MainCat)) return;
    if (string.IsNullOrWhiteSpace(content.SubCat)) return;
    if (string.IsNullOrWhiteSpace(content.Name)) return;
    if (string.IsNullOrWhiteSpace(content.Title)) return;

    var docDirectory = Path.Combine(exportPath, content.MainCat, content.SubCat, content.Name);
    var docPath = Path.Combine(docDirectory, "index.html");
    
    if (!Directory.Exists(docDirectory))
    {
        Directory.CreateDirectory(docDirectory);
    }

    if (!map.ContainsKey(content.MainCat))
    {
        map.Add(content.MainCat, new List<DocInfo>());
    }
    
    map.GetValueOrDefault(content.MainCat)!.Add(new DocInfo(content.Title, docPath));

    using StreamWriter file = new(docPath);

    file.WriteLine("<html>");
    file.WriteLine("<head>");
    // file.WriteLine($"<!--ex_title:{content.Title}-->");
    // file.WriteLine($"<!--ex_text:{content.Text}-->");
    // file.WriteLine($"<!--ex_date:{content.Date:s}-->");
    // file.WriteLine($"<!--ex_author:{content.Postername}-->");
    // file.WriteLine($"<!--ex_price:{content.Price}-->");
    // file.WriteLine($"<!--ex_source:{content.Source}-->");
    // file.WriteLine($"<!--ex_sourceurl:{content.Sourceurl}-->");
    file.WriteLine("</head>");
    file.WriteLine("<body>");
    file.WriteLine($"<span id=\"ex_title\">{content.Title}</span></br>");
    file.WriteLine($"<span id=\"ex_text\">{content.Text}</span></br>");
    file.WriteLine($"<span id=\"ex_date\">{content.Date:s}</span></br>");
    file.WriteLine($"<span id=\"ex_author\">{content.Postername}</span></br>");
    file.WriteLine($"<span id=\"ex_price\">{content.Price}</span></br>");
    file.WriteLine($"<span id=\"ex_source\">{content.Source}</span></br>");
    file.WriteLine($"<span id=\"ex_sourceurl\">{content.Sourceurl}</span></br>");
    file.WriteLine($"<span id=\"ex_mid_cat\">{content.MidCat}</span></br>");
    file.WriteLine($"<span id=\"ex_sub_cat\">{content.SubCat}</span></br>");
    file.WriteLine($"<h1>{content.Title}</h1>");
    file.WriteLine($"<h2>{content.Text}</h2>");
    file.WriteLine("<article>");

    foreach (var page in content.TableContentData.OrderBy(c => c.Page))
    {
        file.WriteLine(
            $"<span id=\"ex_title_{page.Page}\" class=\"ex_title\" style=\"display: none;\">{page.Title}</span>");
        file.WriteLine($"<!--pagetitle:{page.Title}-->");

        HtmlDocument doc = new();
        doc.LoadHtml(page.Text);

        foreach (var imageTag in doc.DocumentNode.Descendants("img"))
        {
            var srcValue = imageTag.GetAttributeValue("src", null);
            if (srcValue.StartsWith("http"))
            {
                var absoluteUrl = new Uri(srcValue);

                if (absoluteUrl.Host == "www.overclock3d.net")
                {
                    imageTag.SetAttributeValue("src", absoluteUrl.PathAndQuery);
                }
            }
        }

        doc.Save(file);

        // doc won't end in a line return
        file.WriteLine();
    }

    file.WriteLine("</article>");
    file.WriteLine("</body>");
    file.WriteLine("</html>");

    file.Flush();
}

foreach (var (mainCat, pages) in map)
{
    using StreamWriter file = new(Path.Combine(exportPath, mainCat, "index.html"));

    file.WriteLine("<html>");
    file.WriteLine("<body>");
    file.WriteLine("<ul>");
    
    foreach (var (title, localPath) in pages)
    {
        var relativePath = localPath
            .Replace(exportPath, string.Empty)
            .Replace('\\', '/');
        
        file.WriteLine($"<li><a href=\"{relativePath}\">{title}</a></li>");
    }

    file.WriteLine("</ul>");
    file.WriteLine("</body>");
    file.WriteLine("</html>");
}

Console.WriteLine($"Finished in {sw.Elapsed:g}");

public record DocInfo(string Title, string LocalPath);
// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Overclock3D.Database;

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

const string outputPath = @"C:\overclock\";
if (Directory.Exists(outputPath)) Directory.Delete(outputPath, true);

var contents = overclockContext.Tblcontents
    .Include(c => c.TableContentData);

Dictionary<string, List<(string RelativeUrl, string Title)>> map = new();

foreach (var content in contents)
{
    if (string.IsNullOrWhiteSpace(content.MainCat)) return;
    if (string.IsNullOrWhiteSpace(content.SubCat)) return;
    if (string.IsNullOrWhiteSpace(content.Name)) return;
    if (string.IsNullOrWhiteSpace(content.Title)) return;

    var contentPath = Path.Combine(outputPath, content.MainCat, content.SubCat, content.Name);
    if (!Directory.Exists(contentPath)) Directory.CreateDirectory(contentPath);

    var contentFile = contentPath + @"\index.html";

    if (!map.ContainsKey(content.MainCat)) map.Add(content.MainCat, new List<(string RelativeUrl, string Title)>());
    map.GetValueOrDefault(content.MainCat)!.Add(('/' + string.Join('/', content.MainCat, content.SubCat, content.Name, "index.html"), content.Title));

    using StreamWriter file = new(contentFile);

    file.WriteLine("<html>");
    file.WriteLine("<head>");
    file.WriteLine($"<!--ex_title:{content.Title}-->");
    file.WriteLine($"<!--ex_text:{content.Text}-->");
    file.WriteLine($"<!--ex_date:{content.Date:s}-->");
    file.WriteLine($"<!--ex_author:{content.Postername}-->");
    file.WriteLine($"<!--ex_price:{content.Price}-->");
    file.WriteLine($"<!--ex_source:{content.Source}-->");
    file.WriteLine($"<!--ex_sourceurl:{content.Sourceurl}-->");
    file.WriteLine("</head>");
    file.WriteLine("<body>");
    file.WriteLine($"<span id=\"ex_title\" style=\"display: none;\">{content.Title}</span>");
    file.WriteLine($"<span id=\"ex_text\" style=\"display: none;\">{content.Text}</span>");
    file.WriteLine($"<span id=\"ex_date\" style=\"display: none;\">{content.Date:s}</span>");
    file.WriteLine($"<span id=\"ex_author\" style=\"display: none;\">{content.Postername}</span>");
    file.WriteLine($"<span id=\"ex_price\" style=\"display: none;\">{content.Price}</span>");
    file.WriteLine($"<span id=\"ex_source\" style=\"display: none;\">{content.Source}</span>");
    file.WriteLine($"<span id=\"ex_sourceurl\" style=\"display: none;\">{content.Sourceurl}</span>");
    var allCategories = string.Join(',', content.MainCat, content.MidCat, content.SubCat);
    file.WriteLine($"<span id=\"ex_cat\" style=\"display: none;\">{allCategories}</span>");
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
    var catIndexPath = Path.Combine(outputPath, mainCat) + @"\index.html";
    using StreamWriter file = new(catIndexPath);

    file.WriteLine("<html>");
    file.WriteLine("<body>");
    file.WriteLine("<ul>");
    foreach (var (relativeUrl, title) in pages)
    {
        file.WriteLine($"<li><a href=\"{relativeUrl}\">{title}</a></li>");
    }

    file.WriteLine("</ul>");
    file.WriteLine("</body>");
    file.WriteLine("</html>");
}

Console.WriteLine("Done.");
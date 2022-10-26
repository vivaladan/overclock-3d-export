namespace Overclock3D.Database.Models
{
    public partial class IpbrssExport
    {
        public int RssExportId { get; set; }
        public bool RssExportEnabled { get; set; }
        public string RssExportTitle { get; set; } = null!;
        public string RssExportDesc { get; set; } = null!;
        public string RssExportImage { get; set; } = null!;
        public string? RssExportForums { get; set; }
        public bool RssExportIncludePost { get; set; }
        public short RssExportCount { get; set; }
        public short RssExportCacheTime { get; set; }
        public int RssExportCacheLast { get; set; }
        public string? RssExportCacheContent { get; set; }
        public string RssExportSort { get; set; } = null!;
        public string RssExportOrder { get; set; } = null!;
    }
}

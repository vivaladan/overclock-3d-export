namespace Overclock3D.Database.Models
{
    public partial class IpbrssImport
    {
        public int RssImportId { get; set; }
        public bool RssImportEnabled { get; set; }
        public string RssImportTitle { get; set; } = null!;
        public string RssImportUrl { get; set; } = null!;
        public int RssImportForumId { get; set; }
        public int RssImportMid { get; set; }
        public short RssImportPergo { get; set; }
        public short RssImportTime { get; set; }
        public int RssImportLastImport { get; set; }
        public string RssImportShowlink { get; set; } = null!;
        public bool RssImportTopicOpen { get; set; }
        public bool RssImportTopicHide { get; set; }
        public bool RssImportIncPcount { get; set; }
        public string RssImportTopicPre { get; set; } = null!;
        public bool RssImportAllowHtml { get; set; }
        public bool RssImportAuth { get; set; }
        public string RssImportAuthUser { get; set; } = null!;
        public string RssImportAuthPass { get; set; } = null!;
    }
}

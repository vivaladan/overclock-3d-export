namespace Overclock3D.Database.Models
{
    public partial class IpbcoreApplication
    {
        public int AppId { get; set; }
        public string AppTitle { get; set; } = null!;
        public string AppPublicTitle { get; set; } = null!;
        public string AppDescription { get; set; } = null!;
        public string AppAuthor { get; set; } = null!;
        public string AppVersion { get; set; } = null!;
        public int AppLongVersion { get; set; }
        public string AppDirectory { get; set; } = null!;
        public int AppAdded { get; set; }
        public int AppPosition { get; set; }
        public int AppProtected { get; set; }
        public int AppEnabled { get; set; }
        public string AppLocation { get; set; } = null!;
        public bool AppHideTab { get; set; }
        public string? AppTabGroups { get; set; }
        public string? AppWebsite { get; set; }
        public string? AppUpdateCheck { get; set; }
        public string? AppGlobalCaches { get; set; }
    }
}

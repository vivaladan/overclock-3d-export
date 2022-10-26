namespace Overclock3D.Database.Models
{
    public partial class IpbcoreSysSettingsTitle
    {
        public short ConfTitleId { get; set; }
        public string ConfTitleTitle { get; set; } = null!;
        public string? ConfTitleDesc { get; set; }
        public short ConfTitleCount { get; set; }
        public bool ConfTitleNoshow { get; set; }
        public string ConfTitleKeyword { get; set; } = null!;
        public string ConfTitleApp { get; set; } = null!;
        public string? ConfTitleTab { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class Ipbannouncement
    {
        public uint AnnounceId { get; set; }
        public string AnnounceTitle { get; set; } = null!;
        public string AnnouncePost { get; set; } = null!;
        public string? AnnounceForum { get; set; }
        public uint AnnounceMemberId { get; set; }
        public bool AnnounceHtmlEnabled { get; set; }
        public bool AnnounceNlbrEnabled { get; set; }
        public uint AnnounceViews { get; set; }
        public uint AnnounceStart { get; set; }
        public uint AnnounceEnd { get; set; }
        public bool? AnnounceActive { get; set; }
    }
}

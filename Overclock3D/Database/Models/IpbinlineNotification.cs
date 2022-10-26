namespace Overclock3D.Database.Models
{
    public partial class IpbinlineNotification
    {
        public int NotifyId { get; set; }
        public int NotifyToId { get; set; }
        public int NotifySent { get; set; }
        public int NotifyRead { get; set; }
        public string? NotifyTitle { get; set; }
        public string? NotifyText { get; set; }
        public int NotifyFromId { get; set; }
        public string? NotifyTypeKey { get; set; }
        public string? NotifyUrl { get; set; }
        public string? NotifyMetaApp { get; set; }
        public string? NotifyMetaArea { get; set; }
        public int? NotifyMetaId { get; set; }
        public string? NotifyMetaKey { get; set; }
    }
}

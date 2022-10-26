namespace Overclock3D.Database.Models
{
    public partial class IpbmobileNotification
    {
        public uint Id { get; set; }
        public string NotifyTitle { get; set; } = null!;
        public uint NotifyDate { get; set; }
        public uint MemberId { get; set; }
        public byte NotifySent { get; set; }
    }
}

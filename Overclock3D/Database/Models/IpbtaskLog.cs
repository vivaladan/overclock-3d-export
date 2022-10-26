namespace Overclock3D.Database.Models
{
    public partial class IpbtaskLog
    {
        public int LogId { get; set; }
        public string LogTitle { get; set; } = null!;
        public int LogDate { get; set; }
        public string LogIp { get; set; } = null!;
        public string? LogDesc { get; set; }
    }
}

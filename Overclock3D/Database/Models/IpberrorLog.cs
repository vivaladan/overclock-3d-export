namespace Overclock3D.Database.Models
{
    public partial class IpberrorLog
    {
        public int LogId { get; set; }
        public int LogMember { get; set; }
        public int LogDate { get; set; }
        public string? LogError { get; set; }
        public string LogErrorCode { get; set; } = null!;
        public string? LogIpAddress { get; set; }
        public string? LogRequestUri { get; set; }
    }
}

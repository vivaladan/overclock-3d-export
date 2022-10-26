namespace Overclock3D.Database.Models
{
    public partial class IpbcoreShareLinksLog
    {
        public int LogId { get; set; }
        public int LogDate { get; set; }
        public int LogMemberId { get; set; }
        public string? LogUrl { get; set; }
        public string? LogTitle { get; set; }
        public string LogShareKey { get; set; } = null!;
        public string LogDataApp { get; set; } = null!;
        public string LogDataType { get; set; } = null!;
        public int LogDataPrimaryId { get; set; }
        public int LogDataSecondaryId { get; set; }
        public string LogIpAddress { get; set; } = null!;
    }
}

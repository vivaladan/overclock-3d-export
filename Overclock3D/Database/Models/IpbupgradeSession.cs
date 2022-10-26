namespace Overclock3D.Database.Models
{
    public partial class IpbupgradeSession
    {
        public string SessionId { get; set; } = null!;
        public int SessionMemberId { get; set; }
        public string SessionMemberKey { get; set; } = null!;
        public int SessionStartTime { get; set; }
        public int SessionCurrentTime { get; set; }
        public string SessionIpAddress { get; set; } = null!;
        public string SessionSection { get; set; } = null!;
        public string? SessionPost { get; set; }
        public string? SessionGet { get; set; }
        public string? SessionData { get; set; }
        public string? SessionExtra { get; set; }
    }
}

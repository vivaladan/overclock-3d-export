namespace Overclock3D.Database.Models
{
    public partial class IpbcoreSysCpSession
    {
        public string SessionId { get; set; } = null!;
        public string SessionIpAddress { get; set; } = null!;
        public string SessionMemberName { get; set; } = null!;
        public int SessionMemberId { get; set; }
        public string SessionMemberLoginKey { get; set; } = null!;
        public string SessionLocation { get; set; } = null!;
        public int SessionLogInTime { get; set; }
        public int SessionRunningTime { get; set; }
        public string? SessionUrl { get; set; }
        public string? SessionAppData { get; set; }
    }
}

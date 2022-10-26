namespace Overclock3D.Database.Models
{
    public partial class IpbsearchSession
    {
        public string SessionId { get; set; } = null!;
        public int SessionCreated { get; set; }
        public int SessionUpdated { get; set; }
        public int SessionMemberId { get; set; }
        public string? SessionData { get; set; }
    }
}

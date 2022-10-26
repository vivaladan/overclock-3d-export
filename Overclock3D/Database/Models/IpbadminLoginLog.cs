namespace Overclock3D.Database.Models
{
    public partial class IpbadminLoginLog
    {
        public int AdminId { get; set; }
        public string AdminIpAddress { get; set; } = null!;
        public string AdminUsername { get; set; } = null!;
        public uint AdminTime { get; set; }
        public uint AdminSuccess { get; set; }
        public string? AdminPostDetails { get; set; }
    }
}

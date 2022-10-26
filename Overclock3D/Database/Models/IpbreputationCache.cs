namespace Overclock3D.Database.Models
{
    public partial class IpbreputationCache
    {
        public long Id { get; set; }
        public string App { get; set; } = null!;
        public string Type { get; set; } = null!;
        public uint TypeId { get; set; }
        public int RepPoints { get; set; }
        public string? RepLikeCache { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbcacheSimple
    {
        public string CacheId { get; set; } = null!;
        public string CachePermKey { get; set; } = null!;
        public int CacheTime { get; set; }
        public string? CacheData { get; set; }
    }
}

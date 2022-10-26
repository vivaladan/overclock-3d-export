namespace Overclock3D.Database.Models
{
    public partial class IpbcoreShareLinksCache
    {
        public int CacheId { get; set; }
        public string CacheKey { get; set; } = null!;
        public string? CacheData { get; set; }
        public int CacheDate { get; set; }
    }
}

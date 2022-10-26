namespace Overclock3D.Database.Models
{
    public partial class IpbcoreLikeCache
    {
        public string LikeCacheId { get; set; } = null!;
        public string LikeCacheApp { get; set; } = null!;
        public string LikeCacheArea { get; set; } = null!;
        public ulong LikeCacheRelId { get; set; }
        public string? LikeCacheData { get; set; }
        public int LikeCacheExpire { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbcoreTagsCache
    {
        public string TagCacheKey { get; set; } = null!;
        public string? TagCacheText { get; set; }
        public int TagCacheDate { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbcoreItemMarker
    {
        public string ItemKey { get; set; } = null!;
        public int ItemMemberId { get; set; }
        public string ItemApp { get; set; } = null!;
        public int ItemLastUpdate { get; set; }
        public int ItemLastSaved { get; set; }
        public int ItemUnreadCount { get; set; }
        public string? ItemReadArray { get; set; }
        public int ItemGlobalReset { get; set; }
        public int ItemAppKey1 { get; set; }
        public int ItemAppKey2 { get; set; }
        public int ItemAppKey3 { get; set; }
        public int ItemIsDeleted { get; set; }
    }
}

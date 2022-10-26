namespace Overclock3D.Database.Models
{
    public partial class IpbcoreLike
    {
        public string LikeId { get; set; } = null!;
        public string? LikeLookupId { get; set; }
        public string LikeLookupArea { get; set; } = null!;
        public string LikeApp { get; set; } = null!;
        public string LikeArea { get; set; } = null!;
        public ulong LikeRelId { get; set; }
        public uint LikeMemberId { get; set; }
        public int LikeIsAnon { get; set; }
        public uint LikeAdded { get; set; }
        public int LikeNotifyDo { get; set; }
        public string? LikeNotifyMeta { get; set; }
        public string LikeNotifyFreq { get; set; } = null!;
        public uint LikeNotifySent { get; set; }
        public sbyte LikeVisible { get; set; }
    }
}

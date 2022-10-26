namespace Overclock3D.Database.Models
{
    public partial class IpbmemberStatusUpdate
    {
        public int StatusId { get; set; }
        public uint StatusMemberId { get; set; }
        public uint StatusDate { get; set; }
        public string? StatusContent { get; set; }
        public uint StatusReplies { get; set; }
        public string? StatusLastIds { get; set; }
        public int StatusIsLatest { get; set; }
        public int StatusIsLocked { get; set; }
        public string StatusHash { get; set; } = null!;
        public int StatusImported { get; set; }
        public string StatusCreator { get; set; } = null!;
        public uint StatusAuthorId { get; set; }
        public string StatusAuthorIp { get; set; } = null!;
        public int StatusApproved { get; set; }
    }
}

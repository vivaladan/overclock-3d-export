namespace Overclock3D.Database.Models
{
    public partial class IpbmemberStatusReply
    {
        public int ReplyId { get; set; }
        public uint ReplyStatusId { get; set; }
        public uint ReplyMemberId { get; set; }
        public uint ReplyDate { get; set; }
        public string? ReplyContent { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbmessageTopic
    {
        public int MtId { get; set; }
        public int MtDate { get; set; }
        public string MtTitle { get; set; } = null!;
        public short MtHasattach { get; set; }
        public int MtStarterId { get; set; }
        public int MtStartTime { get; set; }
        public int MtLastPostTime { get; set; }
        public string? MtInvitedMembers { get; set; }
        public int MtToCount { get; set; }
        public int MtToMemberId { get; set; }
        public int MtReplies { get; set; }
        public int MtLastMsgId { get; set; }
        public int MtFirstMsgId { get; set; }
        public int MtIsDraft { get; set; }
        public int MtIsDeleted { get; set; }
        public int MtIsSystem { get; set; }
    }
}

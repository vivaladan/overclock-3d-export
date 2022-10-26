namespace Overclock3D.Database.Models
{
    public partial class IpbmessageTopicUserMap
    {
        public int MapId { get; set; }
        public int MapUserId { get; set; }
        public int MapTopicId { get; set; }
        public string MapFolderId { get; set; } = null!;
        public int MapReadTime { get; set; }
        public int MapUserActive { get; set; }
        public int MapUserBanned { get; set; }
        public int MapHasUnread { get; set; }
        public int MapIsSystem { get; set; }
        public int MapIsStarter { get; set; }
        public int MapLeftTime { get; set; }
        public int MapIgnoreNotification { get; set; }
        public int MapLastTopicReply { get; set; }
    }
}

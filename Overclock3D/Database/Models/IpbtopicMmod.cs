namespace Overclock3D.Database.Models
{
    public partial class IpbtopicMmod
    {
        public short MmId { get; set; }
        public string MmTitle { get; set; } = null!;
        public bool MmEnabled { get; set; }
        public string TopicState { get; set; } = null!;
        public string TopicPin { get; set; } = null!;
        public short TopicMove { get; set; }
        public bool TopicMoveLink { get; set; }
        public string TopicTitleSt { get; set; } = null!;
        public string TopicTitleEnd { get; set; } = null!;
        public bool TopicReply { get; set; }
        public string? TopicReplyContent { get; set; }
        public bool TopicReplyPostcount { get; set; }
        public string? MmForums { get; set; }
        public bool TopicApprove { get; set; }
    }
}

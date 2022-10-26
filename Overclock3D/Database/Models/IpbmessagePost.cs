namespace Overclock3D.Database.Models
{
    public partial class IpbmessagePost
    {
        public int MsgId { get; set; }
        public int MsgTopicId { get; set; }
        public int? MsgDate { get; set; }
        public string? MsgPost { get; set; }
        public string MsgPostKey { get; set; } = null!;
        public int MsgAuthorId { get; set; }
        public string MsgIpAddress { get; set; } = null!;
        public int MsgIsFirstPost { get; set; }
    }
}

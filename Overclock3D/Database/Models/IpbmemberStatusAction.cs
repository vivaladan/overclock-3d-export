namespace Overclock3D.Database.Models
{
    public partial class IpbmemberStatusAction
    {
        public int ActionId { get; set; }
        public uint ActionStatusId { get; set; }
        public uint ActionReplyId { get; set; }
        public uint ActionMemberId { get; set; }
        public uint ActionDate { get; set; }
        public string ActionKey { get; set; } = null!;
        public uint ActionStatusOwner { get; set; }
        public string ActionApp { get; set; } = null!;
        public string? ActionCustomText { get; set; }
        public int ActionCustom { get; set; }
        public string? ActionCustomUrl { get; set; }
    }
}

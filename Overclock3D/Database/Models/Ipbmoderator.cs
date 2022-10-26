namespace Overclock3D.Database.Models
{
    public partial class Ipbmoderator
    {
        public int Mid { get; set; }
        public string? ForumId { get; set; }
        public string MemberName { get; set; } = null!;
        public int MemberId { get; set; }
        public bool? EditPost { get; set; }
        public bool? EditTopic { get; set; }
        public bool? DeletePost { get; set; }
        public bool? DeleteTopic { get; set; }
        public bool? ViewIp { get; set; }
        public bool? OpenTopic { get; set; }
        public bool? CloseTopic { get; set; }
        public bool? MassMove { get; set; }
        public bool? MassPrune { get; set; }
        public bool? MoveTopic { get; set; }
        public bool? PinTopic { get; set; }
        public bool? UnpinTopic { get; set; }
        public bool? PostQ { get; set; }
        public bool? TopicQ { get; set; }
        public bool? AllowWarn { get; set; }
        public bool? IsGroup { get; set; }
        public short? GroupId { get; set; }
        public string? GroupName { get; set; }
        public bool? SplitMerge { get; set; }
        public bool CanMm { get; set; }
        public bool ModCanSetOpenTime { get; set; }
        public bool ModCanSetCloseTime { get; set; }
        public uint ModBitoptions { get; set; }
    }
}

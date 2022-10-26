namespace Overclock3D.Database.Models
{
    public partial class Ipbgroup
    {
        public uint GId { get; set; }
        public bool? GViewBoard { get; set; }
        public bool? GMemInfo { get; set; }
        public bool? GOtherTopics { get; set; }
        public bool? GUseSearch { get; set; }
        public bool? GEditProfile { get; set; }
        public bool? GPostNewTopics { get; set; }
        public bool? GReplyOwnTopics { get; set; }
        public bool? GReplyOtherTopics { get; set; }
        public bool? GEditPosts { get; set; }
        public bool? GDeleteOwnPosts { get; set; }
        public bool? GOpenClosePosts { get; set; }
        public bool? GDeleteOwnTopics { get; set; }
        public bool? GPostPolls { get; set; }
        public bool? GVotePolls { get; set; }
        public bool? GUsePm { get; set; }
        public bool? GIsSupmod { get; set; }
        public bool? GAccessCp { get; set; }
        public string GTitle { get; set; } = null!;
        public bool? GAppendEdit { get; set; }
        public bool? GAccessOffline { get; set; }
        public bool? GAvoidQ { get; set; }
        public bool? GAvoidFlood { get; set; }
        public string? GIcon { get; set; }
        public long? GAttachMax { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
        public int? GMaxMessages { get; set; }
        public int? GMaxMassPm { get; set; }
        public int? GSearchFlood { get; set; }
        public int? GEditCutoff { get; set; }
        public string? GPromotion { get; set; }
        public bool? GHideFromList { get; set; }
        public bool? GPostClosed { get; set; }
        public string GPermId { get; set; } = null!;
        public string? GPhotoMaxVars { get; set; }
        public bool GDohtml { get; set; }
        public bool GEditTopic { get; set; }
        public bool GBypassBadwords { get; set; }
        public bool GCanMsgAttach { get; set; }
        public int GAttachPerPost { get; set; }
        public short GTopicRateSetting { get; set; }
        public int GDnameChanges { get; set; }
        public int GDnameDate { get; set; }
        public byte GModPreview { get; set; }
        public uint GRepMaxPositive { get; set; }
        public uint GRepMaxNegative { get; set; }
        public string? GSignatureLimits { get; set; }
        public bool? GCanAddFriends { get; set; }
        public bool GHideOnlineList { get; set; }
        public uint GBitoptions { get; set; }
        public short GPmPerday { get; set; }
        public uint GModPostUnit { get; set; }
        public uint GPpdLimit { get; set; }
        public uint GPpdUnit { get; set; }
        public uint GDisplaynameUnit { get; set; }
        public uint GSigUnit { get; set; }
        public uint GPmFloodMins { get; set; }
        public int GMaxNotifications { get; set; }
        public int GMaxBgimgUpload { get; set; }
    }
}

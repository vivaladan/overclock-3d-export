namespace Overclock3D.Database.Models
{
    public partial class Ipbmember
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = null!;
        public short MemberGroupId { get; set; }
        public string Email { get; set; } = null!;
        public int Joined { get; set; }
        public string IpAddress { get; set; } = null!;
        public int? Posts { get; set; }
        public string? Title { get; set; }
        public bool? AllowAdminMails { get; set; }
        public string? TimeOffset { get; set; }
        public short? Skin { get; set; }
        public int? WarnLevel { get; set; }
        public int WarnLastwarn { get; set; }
        public int? Language { get; set; }
        public int? LastPost { get; set; }
        public string RestrictPost { get; set; } = null!;
        public bool? ViewSigs { get; set; }
        public bool? ViewImg { get; set; }
        public int? BdayDay { get; set; }
        public int? BdayMonth { get; set; }
        public int? BdayYear { get; set; }
        public int MsgCountNew { get; set; }
        public int MsgCountTotal { get; set; }
        public int MsgCountReset { get; set; }
        public int MsgShowNotification { get; set; }
        public string? Misc { get; set; }
        public int? LastVisit { get; set; }
        public int? LastActivity { get; set; }
        public bool? DstInUse { get; set; }
        public bool? CoppaUser { get; set; }
        public string ModPosts { get; set; } = null!;
        public string? AutoTrack { get; set; }
        public string? TempBan { get; set; }
        public int SubEnd { get; set; }
        public string LoginAnonymous { get; set; } = null!;
        public string? IgnoredUsers { get; set; }
        public string MgroupOthers { get; set; } = null!;
        public string OrgPermId { get; set; } = null!;
        public string MemberLoginKey { get; set; } = null!;
        public int MemberLoginKeyExpire { get; set; }
        public short SubsPkgChosen { get; set; }
        public string? HasBlog { get; set; }
        public bool HasGallery { get; set; }
        public string MembersEditorChoice { get; set; } = null!;
        public bool? MembersAutoDst { get; set; }
        public string MembersDisplayName { get; set; } = null!;
        public string MembersSeoName { get; set; } = null!;
        public bool MembersCreatedRemote { get; set; }
        public string? MembersCache { get; set; }
        public int MembersDisablePm { get; set; }
        public string MembersLDisplayName { get; set; } = null!;
        public string MembersLUsername { get; set; } = null!;
        public string? FailedLogins { get; set; }
        public short FailedLoginCount { get; set; }
        public uint MembersProfileViews { get; set; }
        public string MembersPassHash { get; set; } = null!;
        public string MembersPassSalt { get; set; } = null!;
        public string? IdentityUrl { get; set; }
        public bool MemberBanned { get; set; }
        public string MemberUploader { get; set; } = null!;
        public uint MembersBitoptions { get; set; }
        public ulong FbUid { get; set; }
        public string FbEmailhash { get; set; } = null!;
        public int FbLastsync { get; set; }
        public string MembersDayPosts { get; set; } = null!;
        public string? LiveId { get; set; }
        public string TwitterId { get; set; } = null!;
        public string TwitterToken { get; set; } = null!;
        public string TwitterSecret { get; set; } = null!;
        public int NotificationCnt { get; set; }
        public int TcLastsync { get; set; }
        public string FbSession { get; set; } = null!;
        public string? FbToken { get; set; }
        public string? IpsMobileToken { get; set; }
        public string? ConvPassword { get; set; }
    }
}

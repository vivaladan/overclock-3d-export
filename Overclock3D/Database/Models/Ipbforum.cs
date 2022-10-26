namespace Overclock3D.Database.Models
{
    public partial class Ipbforum
    {
        public short Id { get; set; }
        public int? Topics { get; set; }
        public int? Posts { get; set; }
        public int? LastPost { get; set; }
        public int LastPosterId { get; set; }
        public string LastPosterName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public uint? Position { get; set; }
        public bool? UseIbc { get; set; }
        public bool? UseHtml { get; set; }
        public string? Password { get; set; }
        public string? PasswordOverride { get; set; }
        public string? LastTitle { get; set; }
        public int? LastId { get; set; }
        public string? SortKey { get; set; }
        public string? SortOrder { get; set; }
        public sbyte? Prune { get; set; }
        public string Topicfilter { get; set; } = null!;
        public bool? ShowRules { get; set; }
        public bool? PreviewPosts { get; set; }
        public bool? AllowPoll { get; set; }
        public bool AllowPollbump { get; set; }
        public bool? IncPostcount { get; set; }
        public int? SkinId { get; set; }
        public int? ParentId { get; set; }
        public string? RedirectUrl { get; set; }
        public bool RedirectOn { get; set; }
        public int RedirectHits { get; set; }
        public string RulesTitle { get; set; } = null!;
        public string? RulesText { get; set; }
        public string? NotifyModqEmails { get; set; }
        public bool? SubCanPost { get; set; }
        public string? PermissionCustomError { get; set; }
        public bool PermissionShowtopic { get; set; }
        public int QueuedTopics { get; set; }
        public int QueuedPosts { get; set; }
        public bool ForumAllowRating { get; set; }
        public int ForumLastDeletion { get; set; }
        public string? NewestTitle { get; set; }
        public int NewestId { get; set; }
        public uint MinPostsPost { get; set; }
        public uint MinPostsView { get; set; }
        public bool? CanViewOthers { get; set; }
        public bool HideLastInfo { get; set; }
        public string? NameSeo { get; set; }
        public string SeoLastTitle { get; set; } = null!;
        public string SeoLastName { get; set; } = null!;
        public string? LastXTopicIds { get; set; }
        public uint ForumsBitoptions { get; set; }
        public int DisableSharelinks { get; set; }
        public int DeletedPosts { get; set; }
        public int DeletedTopics { get; set; }
        public bool RulesRawHtml { get; set; }
        public string? ConvParent { get; set; }
        public string? TagPredefined { get; set; }
    }
}

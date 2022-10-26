namespace Overclock3D.Database.Models
{
    public partial class Ipbtopic
    {
        public int Tid { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? State { get; set; }
        public int? Posts { get; set; }
        public int StarterId { get; set; }
        public int? StartDate { get; set; }
        public int LastPosterId { get; set; }
        public int? LastPost { get; set; }
        public sbyte? IconId { get; set; }
        public string? StarterName { get; set; }
        public string? LastPosterName { get; set; }
        public string? PollState { get; set; }
        public int? LastVote { get; set; }
        public int? Views { get; set; }
        public short ForumId { get; set; }
        public bool Approved { get; set; }
        public bool? AuthorMode { get; set; }
        public bool? Pinned { get; set; }
        public string? MovedTo { get; set; }
        public short TopicHasattach { get; set; }
        public int TopicFirstpost { get; set; }
        public int TopicQueuedposts { get; set; }
        public int TopicOpenTime { get; set; }
        public int TopicCloseTime { get; set; }
        public ushort TopicRatingTotal { get; set; }
        public ushort TopicRatingHits { get; set; }
        public string TitleSeo { get; set; } = null!;
        public string SeoLastName { get; set; } = null!;
        public string SeoFirstName { get; set; } = null!;
        public int TopicDeletedPosts { get; set; }
        public int TdeleteTime { get; set; }
        public int MovedOn { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsDiscussion
    {
        public uint Discussionid { get; set; }
        public uint Groupid { get; set; }
        public uint Firstpostid { get; set; }
        public uint Lastpostid { get; set; }
        public uint Lastpost { get; set; }
        public string Lastposter { get; set; } = null!;
        public uint Lastposterid { get; set; }
        public uint Visible { get; set; }
        public uint Deleted { get; set; }
        public uint Moderation { get; set; }
        public string? Subscribers { get; set; }
    }
}

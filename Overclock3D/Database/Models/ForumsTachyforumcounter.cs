namespace Overclock3D.Database.Models
{
    public partial class ForumsTachyforumcounter
    {
        public uint Userid { get; set; }
        public ushort Forumid { get; set; }
        public uint Threadcount { get; set; }
        public uint Replycount { get; set; }
    }
}

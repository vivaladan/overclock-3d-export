namespace Overclock3D.Database.Models
{
    public partial class ForumsTachyforumpost
    {
        public uint Userid { get; set; }
        public uint Forumid { get; set; }
        public uint Lastpost { get; set; }
        public string Lastposter { get; set; } = null!;
        public uint Lastpostid { get; set; }
        public string Lastthread { get; set; } = null!;
        public uint Lastthreadid { get; set; }
        public ushort Lasticonid { get; set; }
        public string Lastprefixid { get; set; } = null!;
    }
}

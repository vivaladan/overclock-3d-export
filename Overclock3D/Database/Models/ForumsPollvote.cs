namespace Overclock3D.Database.Models
{
    public partial class ForumsPollvote
    {
        public uint Pollvoteid { get; set; }
        public uint Pollid { get; set; }
        public uint? Userid { get; set; }
        public uint Votedate { get; set; }
        public uint Voteoption { get; set; }
        public uint Votetype { get; set; }
    }
}

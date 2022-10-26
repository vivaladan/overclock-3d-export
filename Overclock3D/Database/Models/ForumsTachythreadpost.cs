namespace Overclock3D.Database.Models
{
    public partial class ForumsTachythreadpost
    {
        public uint Userid { get; set; }
        public uint Threadid { get; set; }
        public uint Lastpost { get; set; }
        public string Lastposter { get; set; } = null!;
        public uint Lastpostid { get; set; }
    }
}

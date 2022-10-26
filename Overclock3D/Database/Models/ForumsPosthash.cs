namespace Overclock3D.Database.Models
{
    public partial class ForumsPosthash
    {
        public uint Userid { get; set; }
        public uint Threadid { get; set; }
        public uint Postid { get; set; }
        public string Dupehash { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

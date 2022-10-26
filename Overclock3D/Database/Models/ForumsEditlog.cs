namespace Overclock3D.Database.Models
{
    public partial class ForumsEditlog
    {
        public uint Postid { get; set; }
        public uint Userid { get; set; }
        public string Username { get; set; } = null!;
        public uint Dateline { get; set; }
        public string Reason { get; set; } = null!;
        public short Hashistory { get; set; }
    }
}

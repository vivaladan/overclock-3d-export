namespace Overclock3D.Database.Models
{
    public partial class ForumsDeletionlog
    {
        public uint Primaryid { get; set; }
        public string Type { get; set; } = null!;
        public uint Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

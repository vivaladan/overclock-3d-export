namespace Overclock3D.Database.Models
{
    public partial class ForumsCpsession
    {
        public uint Userid { get; set; }
        public string Hash { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsAdvPagesUser
    {
        public uint Pageid { get; set; }
        public uint Userid { get; set; }
        public string Layout { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

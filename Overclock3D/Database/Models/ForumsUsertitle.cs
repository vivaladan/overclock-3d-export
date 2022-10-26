namespace Overclock3D.Database.Models
{
    public partial class ForumsUsertitle
    {
        public ushort Usertitleid { get; set; }
        public uint Minposts { get; set; }
        public string Title { get; set; } = null!;
    }
}

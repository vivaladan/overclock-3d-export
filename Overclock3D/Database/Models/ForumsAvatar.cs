namespace Overclock3D.Database.Models
{
    public partial class ForumsAvatar
    {
        public ushort Avatarid { get; set; }
        public string Title { get; set; } = null!;
        public uint Minimumposts { get; set; }
        public string Avatarpath { get; set; } = null!;
        public ushort Imagecategoryid { get; set; }
        public ushort Displayorder { get; set; }
        public long Importavatarid { get; set; }
    }
}

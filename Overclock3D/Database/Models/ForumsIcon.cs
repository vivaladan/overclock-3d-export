namespace Overclock3D.Database.Models
{
    public partial class ForumsIcon
    {
        public ushort Iconid { get; set; }
        public string Title { get; set; } = null!;
        public string Iconpath { get; set; } = null!;
        public ushort Imagecategoryid { get; set; }
        public ushort Displayorder { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsImagecategory
    {
        public ushort Imagecategoryid { get; set; }
        public string Title { get; set; } = null!;
        public ushort Imagetype { get; set; }
        public ushort Displayorder { get; set; }
    }
}

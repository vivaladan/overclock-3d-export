namespace Overclock3D.Database.Models
{
    public partial class ForumsSmilie
    {
        public ushort Smilieid { get; set; }
        public string Title { get; set; } = null!;
        public string Smilietext { get; set; } = null!;
        public string Smiliepath { get; set; } = null!;
        public ushort Imagecategoryid { get; set; }
        public ushort Displayorder { get; set; }
        public long Importsmilieid { get; set; }
    }
}

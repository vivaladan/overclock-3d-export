namespace Overclock3D.Database.Models
{
    public partial class ForumsPhrasetype
    {
        public string Fieldname { get; set; } = null!;
        public string Title { get; set; } = null!;
        public ushort Editrows { get; set; }
        public string Product { get; set; } = null!;
        public ushort Special { get; set; }
    }
}

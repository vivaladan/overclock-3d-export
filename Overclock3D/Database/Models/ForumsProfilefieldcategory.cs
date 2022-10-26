namespace Overclock3D.Database.Models
{
    public partial class ForumsProfilefieldcategory
    {
        public ushort Profilefieldcategoryid { get; set; }
        public short Displayorder { get; set; }
        public string Location { get; set; } = null!;
        public ushort Allowprivacy { get; set; }
    }
}

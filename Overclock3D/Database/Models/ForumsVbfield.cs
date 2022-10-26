namespace Overclock3D.Database.Models
{
    public partial class ForumsVbfield
    {
        public string Fieldname { get; set; } = null!;
        public string Tablename { get; set; } = null!;
        public string Vbmandatory { get; set; } = null!;
        public string? Defaultvalue { get; set; }
        public string Dictionary { get; set; } = null!;
        public string? Product { get; set; }
    }
}

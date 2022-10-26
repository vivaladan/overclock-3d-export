namespace Overclock3D.Database.Models
{
    public partial class ForumsProfilefield
    {
        public ushort Profilefieldid { get; set; }
        public ushort Profilefieldcategoryid { get; set; }
        public short Required { get; set; }
        public short Hidden { get; set; }
        public short Maxlength { get; set; }
        public short Size { get; set; }
        public short Displayorder { get; set; }
        public short Editable { get; set; }
        public string Type { get; set; } = null!;
        public string? Data { get; set; }
        public short Height { get; set; }
        public short Def { get; set; }
        public ushort Optional { get; set; }
        public short Searchable { get; set; }
        public short Memberlist { get; set; }
        public string Regex { get; set; } = null!;
        public short Form { get; set; }
        public short Html { get; set; }
        public short Perline { get; set; }
    }
}

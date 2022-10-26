namespace Overclock3D.Database.Models
{
    public partial class ForumsPhrase
    {
        public uint Phraseid { get; set; }
        public short Languageid { get; set; }
        public string Varname { get; set; } = null!;
        public string Fieldname { get; set; } = null!;
        public string? Text { get; set; }
        public string Product { get; set; } = null!;
        public string Username { get; set; } = null!;
        public uint Dateline { get; set; }
        public string Version { get; set; } = null!;
        public long Importphraseid { get; set; }
    }
}

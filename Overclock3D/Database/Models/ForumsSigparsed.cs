namespace Overclock3D.Database.Models
{
    public partial class ForumsSigparsed
    {
        public uint Userid { get; set; }
        public ushort Styleid { get; set; }
        public ushort Languageid { get; set; }
        public string? Signatureparsed { get; set; }
        public ushort Hasimages { get; set; }
    }
}

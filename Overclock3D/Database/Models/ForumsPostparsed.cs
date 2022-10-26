namespace Overclock3D.Database.Models
{
    public partial class ForumsPostparsed
    {
        public uint Postid { get; set; }
        public uint Dateline { get; set; }
        public ushort Styleid { get; set; }
        public ushort Languageid { get; set; }
        public short Hasimages { get; set; }
        public string? PagetextHtml { get; set; }
    }
}

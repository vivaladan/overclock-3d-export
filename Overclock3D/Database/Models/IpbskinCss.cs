namespace Overclock3D.Database.Models
{
    public partial class IpbskinCss
    {
        public int CssId { get; set; }
        public int CssSetId { get; set; }
        public int CssUpdated { get; set; }
        public string CssGroup { get; set; } = null!;
        public string? CssContent { get; set; }
        public int CssPosition { get; set; }
        public int CssAddedTo { get; set; }
        public string CssApp { get; set; } = null!;
        public int CssAppHide { get; set; }
        public string? CssAttributes { get; set; }
        public string CssModules { get; set; } = null!;
        public int CssRemoved { get; set; }
        public string CssMasterKey { get; set; } = null!;
    }
}

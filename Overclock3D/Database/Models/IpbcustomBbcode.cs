namespace Overclock3D.Database.Models
{
    public partial class IpbcustomBbcode
    {
        public int BbcodeId { get; set; }
        public string BbcodeTitle { get; set; } = null!;
        public string? BbcodeDesc { get; set; }
        public string BbcodeTag { get; set; } = null!;
        public string? BbcodeReplace { get; set; }
        public bool BbcodeUseoption { get; set; }
        public string? BbcodeExample { get; set; }
        public int BbcodeSwitchOption { get; set; }
        public string BbcodeMenuOptionText { get; set; } = null!;
        public string BbcodeMenuContentText { get; set; } = null!;
        public bool BbcodeSingleTag { get; set; }
        public string? BbcodeGroups { get; set; }
        public string? BbcodeSections { get; set; }
        public string? BbcodePhpPlugin { get; set; }
        public bool BbcodeNoParsing { get; set; }
        public bool BbcodeProtected { get; set; }
        public string? BbcodeAliases { get; set; }
        public bool BbcodeOptionalOption { get; set; }
        public string? BbcodeImage { get; set; }
        public string BbcodeApp { get; set; } = null!;
        public string? BbcodeCustomRegex { get; set; }
    }
}

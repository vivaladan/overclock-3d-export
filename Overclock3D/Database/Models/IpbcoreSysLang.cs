namespace Overclock3D.Database.Models
{
    public partial class IpbcoreSysLang
    {
        public uint LangId { get; set; }
        public string LangShort { get; set; } = null!;
        public string LangTitle { get; set; } = null!;
        public byte LangDefault { get; set; }
        public byte LangIsrtl { get; set; }
        public bool LangProtected { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbcoreSysLangWord
    {
        public uint WordId { get; set; }
        public uint LangId { get; set; }
        public string WordApp { get; set; } = null!;
        public string WordPack { get; set; } = null!;
        public string WordKey { get; set; } = null!;
        public string WordDefault { get; set; } = null!;
        public string? WordCustom { get; set; }
        public string WordDefaultVersion { get; set; } = null!;
        public string? WordCustomVersion { get; set; }
        public byte WordJs { get; set; }
    }
}

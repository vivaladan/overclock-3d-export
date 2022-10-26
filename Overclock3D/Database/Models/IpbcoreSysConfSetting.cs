namespace Overclock3D.Database.Models
{
    public partial class IpbcoreSysConfSetting
    {
        public int ConfId { get; set; }
        public string ConfTitle { get; set; } = null!;
        public string? ConfDescription { get; set; }
        public short ConfGroup { get; set; }
        public string ConfType { get; set; } = null!;
        public string ConfKey { get; set; } = null!;
        public string? ConfValue { get; set; }
        public string? ConfDefault { get; set; }
        public string? ConfExtra { get; set; }
        public string? ConfEvalphp { get; set; }
        public bool ConfProtected { get; set; }
        public short ConfPosition { get; set; }
        public string ConfStartGroup { get; set; } = null!;
        public bool? ConfAddCache { get; set; }
        public string? ConfKeywords { get; set; }
    }
}

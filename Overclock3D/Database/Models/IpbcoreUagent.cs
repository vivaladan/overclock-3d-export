namespace Overclock3D.Database.Models
{
    public partial class IpbcoreUagent
    {
        public int UagentId { get; set; }
        public string UagentKey { get; set; } = null!;
        public string UagentName { get; set; } = null!;
        public string? UagentRegex { get; set; }
        public int UagentRegexCapture { get; set; }
        public string UagentType { get; set; } = null!;
        public int UagentPosition { get; set; }
    }
}

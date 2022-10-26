namespace Overclock3D.Database.Models
{
    public partial class IpbcoreShareLink
    {
        public uint ShareId { get; set; }
        public string ShareTitle { get; set; } = null!;
        public string ShareKey { get; set; } = null!;
        public int ShareEnabled { get; set; }
        public int SharePosition { get; set; }
        public int ShareCanonical { get; set; }
    }
}

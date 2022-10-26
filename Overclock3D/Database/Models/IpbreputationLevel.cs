namespace Overclock3D.Database.Models
{
    public partial class IpbreputationLevel
    {
        public uint LevelId { get; set; }
        public int LevelPoints { get; set; }
        public string LevelTitle { get; set; } = null!;
        public string LevelImage { get; set; } = null!;
    }
}

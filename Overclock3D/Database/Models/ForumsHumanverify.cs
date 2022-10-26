namespace Overclock3D.Database.Models
{
    public partial class ForumsHumanverify
    {
        public string Hash { get; set; } = null!;
        public string? Answer { get; set; }
        public uint Dateline { get; set; }
        public ushort Viewed { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsProfileblockprivacy
    {
        public uint Userid { get; set; }
        public string Blockid { get; set; } = null!;
        public ushort Requirement { get; set; }
    }
}

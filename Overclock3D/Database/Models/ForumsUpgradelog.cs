namespace Overclock3D.Database.Models
{
    public partial class ForumsUpgradelog
    {
        public uint Upgradelogid { get; set; }
        public string Script { get; set; } = null!;
        public string Steptitle { get; set; } = null!;
        public ushort Step { get; set; }
        public uint Startat { get; set; }
        public ushort Perpage { get; set; }
        public uint Dateline { get; set; }
    }
}

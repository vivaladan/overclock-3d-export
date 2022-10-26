namespace Overclock3D.Database.Models
{
    public partial class ForumsPlugin
    {
        public uint Pluginid { get; set; }
        public string Title { get; set; } = null!;
        public string Hookname { get; set; } = null!;
        public string? Phpcode { get; set; }
        public string Product { get; set; } = null!;
        public string Devkey { get; set; } = null!;
        public short Active { get; set; }
        public ushort Executionorder { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsPrefix
    {
        public string Prefixid { get; set; } = null!;
        public string Prefixsetid { get; set; } = null!;
        public uint Displayorder { get; set; }
        public uint Options { get; set; }
    }
}

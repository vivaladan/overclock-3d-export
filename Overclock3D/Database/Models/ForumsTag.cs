namespace Overclock3D.Database.Models
{
    public partial class ForumsTag
    {
        public uint Tagid { get; set; }
        public string Tagtext { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsCronlog
    {
        public uint Cronlogid { get; set; }
        public string Varname { get; set; } = null!;
        public uint Dateline { get; set; }
        public string? Description { get; set; }
        public ushort Type { get; set; }
    }
}

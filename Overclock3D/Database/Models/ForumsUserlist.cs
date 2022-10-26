namespace Overclock3D.Database.Models
{
    public partial class ForumsUserlist
    {
        public uint Userid { get; set; }
        public uint Relationid { get; set; }
        public string Type { get; set; } = null!;
        public string Friend { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsUsercss
    {
        public uint Userid { get; set; }
        public string Selector { get; set; } = null!;
        public string Property { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}

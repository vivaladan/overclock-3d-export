namespace Overclock3D.Database.Models
{
    public partial class ForumsUserfield
    {
        public uint Userid { get; set; }
        public string? Temp { get; set; }
        public string? Field1 { get; set; }
        public string? Field2 { get; set; }
        public string? Field3 { get; set; }
        public string? Field4 { get; set; }
        public string Field5 { get; set; } = null!;
        public string Field7 { get; set; } = null!;
        public string Field8 { get; set; } = null!;
    }
}

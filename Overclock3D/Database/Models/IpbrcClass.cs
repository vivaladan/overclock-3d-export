namespace Overclock3D.Database.Models
{
    public partial class IpbrcClass
    {
        public short ComId { get; set; }
        public bool Onoff { get; set; }
        public string ClassTitle { get; set; } = null!;
        public string ClassDesc { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string AuthorUrl { get; set; } = null!;
        public string Pversion { get; set; } = null!;
        public string MyClass { get; set; } = null!;
        public string? GroupCanReport { get; set; }
        public string? ModGroupPerm { get; set; }
        public string ExtraData { get; set; } = null!;
        public bool Lockd { get; set; }
        public string App { get; set; } = null!;
    }
}

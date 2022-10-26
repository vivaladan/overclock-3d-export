namespace Overclock3D.Database.Models
{
    public partial class Ipbbadword
    {
        public int Wid { get; set; }
        public string Type { get; set; } = null!;
        public string? Swop { get; set; }
        public bool? MExact { get; set; }
    }
}

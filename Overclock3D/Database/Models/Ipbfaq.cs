namespace Overclock3D.Database.Models
{
    public partial class Ipbfaq
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Text { get; set; }
        public string? Description { get; set; }
        public short Position { get; set; }
        public string App { get; set; } = null!;
    }
}

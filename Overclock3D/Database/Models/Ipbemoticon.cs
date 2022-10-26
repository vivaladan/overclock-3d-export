namespace Overclock3D.Database.Models
{
    public partial class Ipbemoticon
    {
        public short Id { get; set; }
        public string Typed { get; set; } = null!;
        public string Image { get; set; } = null!;
        public short Clickable { get; set; }
        public string EmoSet { get; set; } = null!;
        public int EmoPosition { get; set; }
    }
}

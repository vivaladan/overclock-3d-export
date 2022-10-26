namespace Overclock3D.Database.Models
{
    public partial class ForumsFaq
    {
        public string Faqname { get; set; } = null!;
        public string Faqparent { get; set; } = null!;
        public ushort Displayorder { get; set; }
        public ushort Volatile { get; set; }
        public string Product { get; set; } = null!;
    }
}

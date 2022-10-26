namespace Overclock3D.Database.Models
{
    public partial class Link
    {
        public long Id { get; set; }
        public bool Type { get; set; }
        public string Title { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string Hash { get; set; } = null!;
        public long Hits { get; set; }
        public bool Uiq { get; set; }
        public string Ip { get; set; } = null!;
        public DateTime Date { get; set; }
        public DateTime Lastupd { get; set; }
    }
}

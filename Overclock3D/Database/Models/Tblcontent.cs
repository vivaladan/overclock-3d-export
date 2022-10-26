namespace Overclock3D.Database.Models
{
    public partial class Tblcontent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MainCat { get; set; }
        public string? MidCat { get; set; }
        public string? SubCat { get; set; }
        public bool? Active { get; set; }
        public bool? Featured { get; set; }
        public string? Image { get; set; }
        public string? Featuredimg { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? Scrollimg { get; set; }
        public int? Posterid { get; set; }
        public string? Postername { get; set; }
        public DateTime Date { get; set; }
        public string? Source { get; set; }
        public string? Sourceurl { get; set; }
        public string? Price { get; set; }
        public string Priceurl { get; set; } = null!;
        public string? Pricesku { get; set; }
        public string? Pricecomp { get; set; }
        public int? Threadid { get; set; }
        public string Video { get; set; } = null!;
        public int? Hits { get; set; }
        public DateTime Lastview { get; set; }
        public string Prevkey { get; set; } = null!;
        public int Oldid { get; set; }
        
        public ICollection<Tblcontentdatum> TableContentData { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class Tblcontentdatum
    {
        public int Id { get; set; }
        public int? Contid { get; set; }
        public int Posterid { get; set; }
        public int? Page { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
    }
}

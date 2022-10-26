namespace Overclock3D.Database.Models
{
    public partial class Tblsnippet
    {
        public int Id { get; set; }
        public string? SubCat { get; set; }
        public bool? Active { get; set; }
        public sbyte Type { get; set; }
        public string? Title { get; set; }
        public string? Site { get; set; }
        public string? Url { get; set; }
        public DateTime Date { get; set; }
    }
}

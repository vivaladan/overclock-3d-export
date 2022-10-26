namespace Overclock3D.Database.Models
{
    public partial class Tblpoll
    {
        public int Id { get; set; }
        public string Question { get; set; } = null!;
        public DateTime Date { get; set; }
        public sbyte Active { get; set; }
        public string Options { get; set; } = null!;
        public string Votes { get; set; } = null!;
        public string Sponsorurl { get; set; } = null!;
    }
}

namespace Overclock3D.Database.Models
{
    public partial class Hit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Ip { get; set; } = null!;
        public string Browser { get; set; } = null!;
    }
}

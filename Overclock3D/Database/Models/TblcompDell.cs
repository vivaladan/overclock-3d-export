namespace Overclock3D.Database.Models
{
    public partial class TblcompDell
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public int Answer { get; set; }
        public string Optin { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}

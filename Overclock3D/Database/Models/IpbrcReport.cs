namespace Overclock3D.Database.Models
{
    public partial class IpbrcReport
    {
        public int Id { get; set; }
        public int Rid { get; set; }
        public string Report { get; set; } = null!;
        public int ReportBy { get; set; }
        public int DateReported { get; set; }
    }
}

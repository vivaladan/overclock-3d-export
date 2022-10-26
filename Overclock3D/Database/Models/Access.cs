namespace Overclock3D.Database.Models
{
    public partial class Access
    {
        public string Ip { get; set; } = null!;
        public DateOnly Date { get; set; }
        public int CountLnk { get; set; }
        public int CountImg { get; set; }
    }
}

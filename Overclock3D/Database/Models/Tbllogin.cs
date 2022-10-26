namespace Overclock3D.Database.Models
{
    public partial class Tbllogin
    {
        public string Username { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public string Type { get; set; } = null!;
        public string Result { get; set; } = null!;
    }
}

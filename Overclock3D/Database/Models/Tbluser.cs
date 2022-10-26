namespace Overclock3D.Database.Models
{
    public partial class Tbluser
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Session { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public int Perms { get; set; }
    }
}

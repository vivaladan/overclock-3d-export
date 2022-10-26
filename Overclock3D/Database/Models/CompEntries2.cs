namespace Overclock3D.Database.Models
{
    public partial class CompEntries2
    {
        public int Id { get; set; }
        public int UserRef { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public DateTime TheDate { get; set; }
    }
}

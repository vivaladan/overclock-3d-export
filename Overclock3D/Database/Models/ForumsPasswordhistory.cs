namespace Overclock3D.Database.Models
{
    public partial class ForumsPasswordhistory
    {
        public uint Userid { get; set; }
        public string Password { get; set; } = null!;
        public DateOnly Passworddate { get; set; }
    }
}

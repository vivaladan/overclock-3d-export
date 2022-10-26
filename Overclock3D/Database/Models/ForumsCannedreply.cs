namespace Overclock3D.Database.Models
{
    public partial class ForumsCannedreply
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public string Title { get; set; } = null!;
        public string Reply { get; set; } = null!;
    }
}

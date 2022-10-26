namespace Overclock3D.Database.Models
{
    public partial class IpbrcComment
    {
        public int Id { get; set; }
        public int Rid { get; set; }
        public string Comment { get; set; } = null!;
        public int CommentBy { get; set; }
        public int CommentDate { get; set; }
        public sbyte Approved { get; set; }
        public int EditDate { get; set; }
        public string? AuthorName { get; set; }
        public string? IpAddress { get; set; }
    }
}

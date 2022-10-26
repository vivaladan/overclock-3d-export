namespace Overclock3D.Database.Models
{
    public partial class ForumsDtoGarageComment
    {
        public uint CommentId { get; set; }
        public uint VehicleId { get; set; }
        public int Userid { get; set; }
        public string Useripaddress { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public DateTime TimeModified { get; set; }
        public DateTime TimeAdded { get; set; }
        public bool? Display { get; set; }
    }
}

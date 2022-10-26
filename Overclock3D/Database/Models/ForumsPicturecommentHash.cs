namespace Overclock3D.Database.Models
{
    public partial class ForumsPicturecommentHash
    {
        public uint Postuserid { get; set; }
        public uint Pictureid { get; set; }
        public string Dupehash { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

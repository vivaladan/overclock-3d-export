namespace Overclock3D.Database.Models
{
    public partial class ForumsAlbum
    {
        public uint Albumid { get; set; }
        public uint Userid { get; set; }
        public uint Createdate { get; set; }
        public uint Lastpicturedate { get; set; }
        public uint Visible { get; set; }
        public uint Moderation { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string State { get; set; } = null!;
        public uint Coverpictureid { get; set; }
    }
}

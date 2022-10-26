namespace Overclock3D.Database.Models
{
    public partial class Ipbattachment
    {
        public int AttachId { get; set; }
        public string AttachExt { get; set; } = null!;
        public string AttachFile { get; set; } = null!;
        public string AttachLocation { get; set; } = null!;
        public string AttachThumbLocation { get; set; } = null!;
        public short AttachThumbWidth { get; set; }
        public short AttachThumbHeight { get; set; }
        public bool AttachIsImage { get; set; }
        public int AttachHits { get; set; }
        public int AttachDate { get; set; }
        public string AttachPostKey { get; set; } = null!;
        public int AttachMemberId { get; set; }
        public int AttachFilesize { get; set; }
        public int AttachRelId { get; set; }
        public string AttachRelModule { get; set; } = null!;
        public int AttachImgWidth { get; set; }
        public int AttachImgHeight { get; set; }
        public int AttachParentId { get; set; }
    }
}

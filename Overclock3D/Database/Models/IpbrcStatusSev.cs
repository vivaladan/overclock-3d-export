namespace Overclock3D.Database.Models
{
    public partial class IpbrcStatusSev
    {
        public short Id { get; set; }
        public sbyte Status { get; set; }
        public short Points { get; set; }
        public string Img { get; set; } = null!;
        public bool IsPng { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
    }
}

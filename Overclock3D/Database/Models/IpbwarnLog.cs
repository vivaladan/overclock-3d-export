namespace Overclock3D.Database.Models
{
    public partial class IpbwarnLog
    {
        public int WlogId { get; set; }
        public int WlogMid { get; set; }
        public string? WlogNotes { get; set; }
        public string WlogContact { get; set; } = null!;
        public string? WlogContactContent { get; set; }
        public int WlogDate { get; set; }
        public string WlogType { get; set; } = null!;
        public int WlogAddedby { get; set; }
    }
}

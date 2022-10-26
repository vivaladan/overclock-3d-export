namespace Overclock3D.Database.Models
{
    public partial class IpbrcStatus
    {
        public sbyte Status { get; set; }
        public string Title { get; set; } = null!;
        public short PointsPerReport { get; set; }
        public double MinutesToApoint { get; set; }
        public bool IsNew { get; set; }
        public bool IsComplete { get; set; }
        public bool IsActive { get; set; }
        public short Rorder { get; set; }
    }
}

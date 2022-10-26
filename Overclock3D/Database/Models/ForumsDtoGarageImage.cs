namespace Overclock3D.Database.Models
{
    public partial class ForumsDtoGarageImage
    {
        public uint ImageId { get; set; }
        public uint VehicleId { get; set; }
        public uint Userid { get; set; }
        public string Caption { get; set; } = null!;
        public DateTime TimeModified { get; set; }
        public DateTime TimeAdded { get; set; }
        public short DisplayOrder { get; set; }
        public uint? ThumbVersion { get; set; }
        public uint? VbaThumbVersion { get; set; }
    }
}

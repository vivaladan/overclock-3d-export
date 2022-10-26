namespace Overclock3D.Database.Models
{
    public partial class IpbmodQueuedItem
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public int TypeId { get; set; }
    }
}

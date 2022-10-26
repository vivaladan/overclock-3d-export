namespace Overclock3D.Database.Models
{
    public partial class IpbcoreItemMarkersStorage
    {
        public int ItemMemberId { get; set; }
        public string? ItemMarkers { get; set; }
        public int ItemLastUpdated { get; set; }
        public int ItemLastSaved { get; set; }
    }
}

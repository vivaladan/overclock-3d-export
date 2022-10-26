namespace Overclock3D.Database.Models
{
    public partial class IpbcoreGeolocationCache
    {
        public string GeocacheKey { get; set; } = null!;
        public string GeocacheLat { get; set; } = null!;
        public string GeocacheLon { get; set; } = null!;
        public string? GeocacheRaw { get; set; }
        public string GeocacheCountry { get; set; } = null!;
        public string GeocacheDistrict { get; set; } = null!;
        public string GeocacheDistrict2 { get; set; } = null!;
        public string GeocacheLocality { get; set; } = null!;
        public string GeocacheType { get; set; } = null!;
        public string GeocacheEngine { get; set; } = null!;
        public int GeocacheAdded { get; set; }
        public string? GeocacheShort { get; set; }
    }
}

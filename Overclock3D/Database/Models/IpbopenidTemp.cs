namespace Overclock3D.Database.Models
{
    public partial class IpbopenidTemp
    {
        public string Id { get; set; } = null!;
        public string? Referrer { get; set; }
        public bool Privacy { get; set; }
        public bool Cookiedate { get; set; }
        public string? Fullurl { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsProduct
    {
        public string Productid { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Version { get; set; } = null!;
        public ushort Active { get; set; }
        public string Url { get; set; } = null!;
        public string Versioncheckurl { get; set; } = null!;
    }
}

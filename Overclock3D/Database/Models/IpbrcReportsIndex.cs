namespace Overclock3D.Database.Models
{
    public partial class IpbrcReportsIndex
    {
        public int Id { get; set; }
        public string Uid { get; set; } = null!;
        public string Title { get; set; } = null!;
        public short Status { get; set; }
        public string Url { get; set; } = null!;
        public string ImgPreview { get; set; } = null!;
        public short RcClass { get; set; }
        public int UpdatedBy { get; set; }
        public int DateUpdated { get; set; }
        public int DateCreated { get; set; }
        public int Exdat1 { get; set; }
        public int Exdat2 { get; set; }
        public int Exdat3 { get; set; }
        public short NumReports { get; set; }
        public short NumComments { get; set; }
        public string? Seoname { get; set; }
        public string? Seotemplate { get; set; }
    }
}

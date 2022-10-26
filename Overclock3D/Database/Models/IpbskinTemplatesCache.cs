namespace Overclock3D.Database.Models
{
    public partial class IpbskinTemplatesCache
    {
        public string TemplateId { get; set; } = null!;
        public string TemplateGroupName { get; set; } = null!;
        public string? TemplateGroupContent { get; set; }
        public int TemplateSetId { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class IpbskinTemplatesPreviou
    {
        public int PTemplateId { get; set; }
        public string PTemplateGroup { get; set; } = null!;
        public string? PTemplateContent { get; set; }
        public string? PTemplateName { get; set; }
        public string? PTemplateData { get; set; }
        public string PTemplateMasterKey { get; set; } = null!;
        public string PTemplateLongVersion { get; set; } = null!;
        public string PTemplateHumanVersion { get; set; } = null!;
    }
}

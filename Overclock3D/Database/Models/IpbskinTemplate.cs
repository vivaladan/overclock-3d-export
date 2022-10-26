namespace Overclock3D.Database.Models
{
    public partial class IpbskinTemplate
    {
        public int TemplateId { get; set; }
        public int TemplateSetId { get; set; }
        public string TemplateGroup { get; set; } = null!;
        public string? TemplateContent { get; set; }
        public string? TemplateName { get; set; }
        public string? TemplateData { get; set; }
        public int TemplateUpdated { get; set; }
        public int TemplateRemovable { get; set; }
        public int TemplateAddedTo { get; set; }
        public int TemplateUserAdded { get; set; }
        public int TemplateUserEdited { get; set; }
        public string TemplateMasterKey { get; set; } = null!;
    }
}

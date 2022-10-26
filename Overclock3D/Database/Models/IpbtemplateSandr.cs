namespace Overclock3D.Database.Models
{
    public partial class IpbtemplateSandr
    {
        public int SandrSessionId { get; set; }
        public int SandrSetId { get; set; }
        public int SandrSearchOnly { get; set; }
        public int SandrSearchAll { get; set; }
        public string? SandrSearchFor { get; set; }
        public string? SandrReplaceWith { get; set; }
        public int SandrIsRegex { get; set; }
        public int SandrTemplateCount { get; set; }
        public int SandrTemplateProcessed { get; set; }
        public string? SandrResults { get; set; }
        public int SandrUpdated { get; set; }
    }
}

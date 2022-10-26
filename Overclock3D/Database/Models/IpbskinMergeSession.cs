namespace Overclock3D.Database.Models
{
    public partial class IpbskinMergeSession
    {
        public int MergeId { get; set; }
        public int MergeDate { get; set; }
        public int MergeSetId { get; set; }
        public string MergeMasterKey { get; set; } = null!;
        public string MergeOldVersion { get; set; } = null!;
        public string MergeNewVersion { get; set; } = null!;
        public int MergeTemplatesTogo { get; set; }
        public int MergeCssTogo { get; set; }
        public int MergeTemplatesDone { get; set; }
        public int MergeCssDone { get; set; }
        public int MergeMTemplatesTogo { get; set; }
        public int MergeMCssTogo { get; set; }
        public int MergeMTemplatesDone { get; set; }
        public int MergeMCssDone { get; set; }
        public int MergeDiffDone { get; set; }
    }
}

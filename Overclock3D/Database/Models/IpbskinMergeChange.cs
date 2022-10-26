namespace Overclock3D.Database.Models
{
    public partial class IpbskinMergeChange
    {
        public int ChangeId { get; set; }
        public string ChangeKey { get; set; } = null!;
        public int ChangeSessionId { get; set; }
        public int ChangeUpdated { get; set; }
        public string ChangeDataGroup { get; set; } = null!;
        public string ChangeDataTitle { get; set; } = null!;
        public string? ChangeDataContent { get; set; }
        public string ChangeDataType { get; set; } = null!;
        public int ChangeIsNew { get; set; }
        public int ChangeIsDiff { get; set; }
        public int ChangeCanMerge { get; set; }
        public string? ChangeMergeContent { get; set; }
        public int ChangeIsConflict { get; set; }
        public string? ChangeFinalContent { get; set; }
        public int ChangeChangesApplied { get; set; }
        public string? ChangeOriginalContent { get; set; }
    }
}

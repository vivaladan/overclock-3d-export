namespace Overclock3D.Database.Models
{
    public partial class ForumsNoticecriterion
    {
        public uint Noticeid { get; set; }
        public string Criteriaid { get; set; } = null!;
        public string Condition1 { get; set; } = null!;
        public string Condition2 { get; set; } = null!;
        public string Condition3 { get; set; } = null!;
    }
}

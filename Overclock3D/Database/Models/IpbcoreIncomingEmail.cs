namespace Overclock3D.Database.Models
{
    public partial class IpbcoreIncomingEmail
    {
        public int RuleId { get; set; }
        public string RuleCriteriaField { get; set; } = null!;
        public string RuleCriteriaType { get; set; } = null!;
        public string RuleCriteriaValue { get; set; } = null!;
        public string RuleApp { get; set; } = null!;
        public int RuleAddedBy { get; set; }
        public int RuleAddedDate { get; set; }
    }
}

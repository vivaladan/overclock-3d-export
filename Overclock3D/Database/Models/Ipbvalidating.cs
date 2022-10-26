namespace Overclock3D.Database.Models
{
    public partial class Ipbvalidating
    {
        public string Vid { get; set; } = null!;
        public int MemberId { get; set; }
        public short RealGroup { get; set; }
        public short TempGroup { get; set; }
        public int EntryDate { get; set; }
        public bool CoppaUser { get; set; }
        public bool LostPass { get; set; }
        public bool NewReg { get; set; }
        public bool EmailChg { get; set; }
        public string IpAddress { get; set; } = null!;
        public bool UserVerified { get; set; }
        public string PrevEmail { get; set; } = null!;
        public sbyte SpamFlag { get; set; }
    }
}

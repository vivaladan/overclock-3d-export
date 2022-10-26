namespace Overclock3D.Database.Models
{
    public partial class ForumsPaymentinfo
    {
        public uint Paymentinfoid { get; set; }
        public string Hash { get; set; } = null!;
        public ushort Subscriptionid { get; set; }
        public ushort Subscriptionsubid { get; set; }
        public uint Userid { get; set; }
        public short Completed { get; set; }
    }
}

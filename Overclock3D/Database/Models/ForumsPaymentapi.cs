namespace Overclock3D.Database.Models
{
    public partial class ForumsPaymentapi
    {
        public uint Paymentapiid { get; set; }
        public string Title { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public short Recurring { get; set; }
        public string Classname { get; set; } = null!;
        public short Active { get; set; }
        public string? Settings { get; set; }
    }
}

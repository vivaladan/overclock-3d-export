namespace Overclock3D.Database.Models
{
    public partial class ForumsPaymenttransaction
    {
        public uint Paymenttransactionid { get; set; }
        public uint Paymentinfoid { get; set; }
        public string Transactionid { get; set; } = null!;
        public ushort State { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; } = null!;
        public uint Dateline { get; set; }
        public uint Paymentapiid { get; set; }
        public string? Request { get; set; }
        public uint Reversed { get; set; }
    }
}

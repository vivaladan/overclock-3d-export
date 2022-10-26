namespace Overclock3D.Database.Models
{
    public partial class ForumsSubscriptionlog
    {
        public uint Subscriptionlogid { get; set; }
        public short Subscriptionid { get; set; }
        public uint Userid { get; set; }
        public short Pusergroupid { get; set; }
        public short Status { get; set; }
        public uint Regdate { get; set; }
        public uint Expirydate { get; set; }
        public long Importsubscriptionlogid { get; set; }
    }
}

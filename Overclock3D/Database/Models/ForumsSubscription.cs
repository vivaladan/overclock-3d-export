namespace Overclock3D.Database.Models
{
    public partial class ForumsSubscription
    {
        public ushort Subscriptionid { get; set; }
        public string Varname { get; set; } = null!;
        public string? Cost { get; set; }
        public string? Forums { get; set; }
        public short Nusergroupid { get; set; }
        public string Membergroupids { get; set; } = null!;
        public ushort Active { get; set; }
        public uint Options { get; set; }
        public ushort Displayorder { get; set; }
        public uint Adminoptions { get; set; }
        public long Importsubscriptionid { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsThreadrate
    {
        public uint Threadrateid { get; set; }
        public uint Threadid { get; set; }
        public uint Userid { get; set; }
        public short Vote { get; set; }
        public string? Ipaddress { get; set; }
    }
}

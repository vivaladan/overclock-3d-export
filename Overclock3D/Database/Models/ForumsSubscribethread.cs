namespace Overclock3D.Database.Models
{
    public partial class ForumsSubscribethread
    {
        public uint Subscribethreadid { get; set; }
        public uint Userid { get; set; }
        public uint Threadid { get; set; }
        public ushort Emailupdate { get; set; }
        public uint Folderid { get; set; }
        public ushort Canview { get; set; }
    }
}

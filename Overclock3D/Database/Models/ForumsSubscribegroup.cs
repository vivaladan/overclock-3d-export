namespace Overclock3D.Database.Models
{
    public partial class ForumsSubscribegroup
    {
        public uint Subscribegroupid { get; set; }
        public uint Userid { get; set; }
        public uint Groupid { get; set; }
        public string Emailupdate { get; set; } = null!;
    }
}

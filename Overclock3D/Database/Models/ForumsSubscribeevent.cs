namespace Overclock3D.Database.Models
{
    public partial class ForumsSubscribeevent
    {
        public uint Subscribeeventid { get; set; }
        public uint Userid { get; set; }
        public uint Eventid { get; set; }
        public uint Lastreminder { get; set; }
        public uint Reminder { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsSubscribediscussion
    {
        public uint Subscribediscussionid { get; set; }
        public uint Userid { get; set; }
        public uint Discussionid { get; set; }
        public ushort Emailupdate { get; set; }
    }
}

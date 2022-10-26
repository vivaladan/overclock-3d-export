namespace Overclock3D.Database.Models
{
    public partial class IpbprofileFriendsFlood
    {
        public int FriendsId { get; set; }
        public uint FriendsMemberId { get; set; }
        public uint FriendsFriendId { get; set; }
        public uint FriendsRemoved { get; set; }
    }
}

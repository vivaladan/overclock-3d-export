namespace Overclock3D.Database.Models
{
    public partial class IpbprofileFriend
    {
        public int FriendsId { get; set; }
        public uint FriendsMemberId { get; set; }
        public uint FriendsFriendId { get; set; }
        public bool FriendsApproved { get; set; }
        public uint FriendsAdded { get; set; }
    }
}

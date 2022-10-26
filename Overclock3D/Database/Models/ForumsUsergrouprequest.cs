namespace Overclock3D.Database.Models
{
    public partial class ForumsUsergrouprequest
    {
        public uint Usergrouprequestid { get; set; }
        public uint Userid { get; set; }
        public ushort Usergroupid { get; set; }
        public string Reason { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

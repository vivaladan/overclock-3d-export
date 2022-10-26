namespace Overclock3D.Database.Models
{
    public partial class ForumsInfractiongroup
    {
        public uint Infractiongroupid { get; set; }
        public int Usergroupid { get; set; }
        public ushort Orusergroupid { get; set; }
        public uint Pointlevel { get; set; }
        public ushort Override { get; set; }
    }
}

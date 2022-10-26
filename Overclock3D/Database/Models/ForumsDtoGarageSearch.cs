namespace Overclock3D.Database.Models
{
    public partial class ForumsDtoGarageSearch
    {
        public uint Searchid { get; set; }
        public uint? Userid { get; set; }
        public string Ipaddress { get; set; } = null!;
        public string? Searchterms { get; set; }
        public string? Displayterms { get; set; }
        public int Dateline { get; set; }
        public ushort Completed { get; set; }
    }
}

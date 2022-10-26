namespace Overclock3D.Database.Models
{
    public partial class ForumsSearch
    {
        public uint Searchid { get; set; }
        public uint Userid { get; set; }
        public string? Ipaddress { get; set; }
        public ushort Personal { get; set; }
        public string Query { get; set; } = null!;
        public string Searchuser { get; set; } = null!;
        public string? Forumchoice { get; set; }
        public string? Prefixchoice { get; set; }
        public string Sortby { get; set; } = null!;
        public string Sortorder { get; set; } = null!;
        public float Searchtime { get; set; }
        public ushort Showposts { get; set; }
        public string? Orderedids { get; set; }
        public string? Announceids { get; set; }
        public uint Dateline { get; set; }
        public string? Searchterms { get; set; }
        public string? Displayterms { get; set; }
        public string Searchhash { get; set; } = null!;
        public ushort Titleonly { get; set; }
        public ushort Completed { get; set; }
    }
}

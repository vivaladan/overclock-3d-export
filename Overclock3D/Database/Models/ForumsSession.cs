namespace Overclock3D.Database.Models
{
    public partial class ForumsSession
    {
        public string Sessionhash { get; set; } = null!;
        public uint Userid { get; set; }
        public string? Host { get; set; }
        public string Idhash { get; set; } = null!;
        public uint Lastactivity { get; set; }
        public string Location { get; set; } = null!;
        public string Useragent { get; set; } = null!;
        public ushort Styleid { get; set; }
        public ushort Languageid { get; set; }
        public ushort Loggedin { get; set; }
        public ushort Inforum { get; set; }
        public uint Inthread { get; set; }
        public ushort Incalendar { get; set; }
        public ushort Badlocation { get; set; }
        public sbyte Bypass { get; set; }
        public ushort Profileupdate { get; set; }
        public uint? Newposts { get; set; }
    }
}

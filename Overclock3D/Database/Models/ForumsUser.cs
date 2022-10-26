namespace Overclock3D.Database.Models
{
    public partial class ForumsUser
    {
        public uint Userid { get; set; }
        public ushort Usergroupid { get; set; }
        public string Membergroupids { get; set; } = null!;
        public ushort Displaygroupid { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateOnly Passworddate { get; set; }
        public string Email { get; set; } = null!;
        public ushort Styleid { get; set; }
        public string Parentemail { get; set; } = null!;
        public string Homepage { get; set; } = null!;
        public string Icq { get; set; } = null!;
        public string Aim { get; set; } = null!;
        public string Yahoo { get; set; } = null!;
        public string Msn { get; set; } = null!;
        public string Skype { get; set; } = null!;
        public ushort Showvbcode { get; set; }
        public ushort Showbirthday { get; set; }
        public string Usertitle { get; set; } = null!;
        public short Customtitle { get; set; }
        public uint Joindate { get; set; }
        public short Daysprune { get; set; }
        public uint Lastvisit { get; set; }
        public uint Lastactivity { get; set; }
        public uint Lastpost { get; set; }
        public uint Lastpostid { get; set; }
        public uint Posts { get; set; }
        public int Reputation { get; set; }
        public uint Reputationlevelid { get; set; }
        public string Timezoneoffset { get; set; } = null!;
        public short Pmpopup { get; set; }
        public short Avatarid { get; set; }
        public uint Avatarrevision { get; set; }
        public uint Profilepicrevision { get; set; }
        public uint Sigpicrevision { get; set; }
        public uint Options { get; set; }
        public string Birthday { get; set; } = null!;
        public DateOnly BirthdaySearch { get; set; }
        public short Maxposts { get; set; }
        public short Startofweek { get; set; }
        public string? Ipaddress { get; set; }
        public uint Referrerid { get; set; }
        public ushort Languageid { get; set; }
        public uint Emailstamp { get; set; }
        public ushort Threadedmode { get; set; }
        public short Autosubscribe { get; set; }
        public ushort Pmtotal { get; set; }
        public ushort Pmunread { get; set; }
        public string Salt { get; set; } = null!;
        public uint Ipoints { get; set; }
        public uint Infractions { get; set; }
        public uint Warnings { get; set; }
        public string Infractiongroupids { get; set; } = null!;
        public ushort Infractiongroupid { get; set; }
        public uint Adminoptions { get; set; }
        public uint Profilevisits { get; set; }
        public uint Friendcount { get; set; }
        public uint Friendreqcount { get; set; }
        public uint Vmunreadcount { get; set; }
        public uint Vmmoderatedcount { get; set; }
        public uint Socgroupinvitecount { get; set; }
        public uint Socgroupreqcount { get; set; }
        public uint Pcunreadcount { get; set; }
        public uint Pcmoderatedcount { get; set; }
        public uint Gmmoderatedcount { get; set; }
        public long Importuserid { get; set; }
        public string? NcodeImageresizerMode { get; set; }
        public ushort? NcodeImageresizerMaxwidth { get; set; }
        public ushort? NcodeImageresizerMaxheight { get; set; }
        public sbyte? ChangedUsername { get; set; }
    }
}

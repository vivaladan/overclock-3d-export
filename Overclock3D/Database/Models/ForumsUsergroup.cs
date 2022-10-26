namespace Overclock3D.Database.Models
{
    public partial class ForumsUsergroup
    {
        public ushort Usergroupid { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Usertitle { get; set; } = null!;
        public ushort Passwordexpires { get; set; }
        public ushort Passwordhistory { get; set; }
        public ushort Pmquota { get; set; }
        public ushort Pmsendmax { get; set; }
        public string Opentag { get; set; } = null!;
        public string Closetag { get; set; } = null!;
        public ushort Canoverride { get; set; }
        public ushort Ispublicgroup { get; set; }
        public uint Forumpermissions { get; set; }
        public uint Pmpermissions { get; set; }
        public uint Calendarpermissions { get; set; }
        public uint Wolpermissions { get; set; }
        public uint Adminpermissions { get; set; }
        public uint Genericpermissions { get; set; }
        public uint Genericpermissions2 { get; set; }
        public uint Genericoptions { get; set; }
        public uint Signaturepermissions { get; set; }
        public uint Visitormessagepermissions { get; set; }
        public uint Attachlimit { get; set; }
        public ushort Avatarmaxwidth { get; set; }
        public ushort Avatarmaxheight { get; set; }
        public uint Avatarmaxsize { get; set; }
        public ushort Profilepicmaxwidth { get; set; }
        public ushort Profilepicmaxheight { get; set; }
        public uint Profilepicmaxsize { get; set; }
        public ushort Sigpicmaxwidth { get; set; }
        public ushort Sigpicmaxheight { get; set; }
        public uint Sigpicmaxsize { get; set; }
        public ushort Sigmaximages { get; set; }
        public ushort Sigmaxsizebbcode { get; set; }
        public ushort Sigmaxchars { get; set; }
        public ushort Sigmaxrawchars { get; set; }
        public ushort Sigmaxlines { get; set; }
        public uint Usercsspermissions { get; set; }
        public uint Albumpermissions { get; set; }
        public ushort Albumpicmaxwidth { get; set; }
        public ushort Albumpicmaxheight { get; set; }
        public uint Albumpicmaxsize { get; set; }
        public uint Albummaxpics { get; set; }
        public uint Albummaxsize { get; set; }
        public uint Socialgrouppermissions { get; set; }
        public uint Pmthrottlequantity { get; set; }
        public uint Groupiconmaxsize { get; set; }
        public uint Maximumsocialgroups { get; set; }
        public long Importusergroupid { get; set; }
        public int? Skhardmodpermissions { get; set; }
        public uint Dtogaragepermissions { get; set; }
        public ushort Dtogaragesize { get; set; }
        public uint Cannedreplies { get; set; }
        public int Maxcr { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsAdvPage
    {
        public uint Pageid { get; set; }
        public string Title { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Template { get; set; } = null!;
        public uint Parentid { get; set; }
        public string Parentlist { get; set; } = null!;
        public string Modules { get; set; } = null!;
        public string Advanced { get; set; } = null!;
        public string Userperms { get; set; } = null!;
        public ushort Styleid { get; set; }
        public ushort Active { get; set; }
        public ushort Colspan { get; set; }
        public string Formcode { get; set; } = null!;
        public ushort Cleanoutput { get; set; }
        public ushort Useshell { get; set; }
        public ushort Customize { get; set; }
        public string CustomTitle { get; set; } = null!;
        public string Meta { get; set; } = null!;
        public ushort Displayorder { get; set; }
        public uint Dateline { get; set; }
    }
}

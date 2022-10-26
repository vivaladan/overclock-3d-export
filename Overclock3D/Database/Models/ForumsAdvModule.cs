namespace Overclock3D.Database.Models
{
    public partial class ForumsAdvModule
    {
        public ushort Modid { get; set; }
        public string Title { get; set; } = null!;
        public string Identifier { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public string Inctype { get; set; } = null!;
        public string Templatelist { get; set; } = null!;
        public string Userperms { get; set; } = null!;
        public string Parent { get; set; } = null!;
        public ushort Active { get; set; }
        public ushort Colspan { get; set; }
        public string Formcode { get; set; } = null!;
        public ushort Useshell { get; set; }
        public string Altshell { get; set; } = null!;
        public string Link { get; set; } = null!;
        public short Options { get; set; }
        public string CodeParsed { get; set; } = null!;
        public string DynaPrefix { get; set; } = null!;
    }
}

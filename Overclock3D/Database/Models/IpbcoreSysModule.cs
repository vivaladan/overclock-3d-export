namespace Overclock3D.Database.Models
{
    public partial class IpbcoreSysModule
    {
        public uint SysModuleId { get; set; }
        public string SysModuleTitle { get; set; } = null!;
        public string SysModuleApplication { get; set; } = null!;
        public string SysModuleKey { get; set; } = null!;
        public string SysModuleDescription { get; set; } = null!;
        public string SysModuleVersion { get; set; } = null!;
        public string SysModuleParent { get; set; } = null!;
        public byte SysModuleProtected { get; set; }
        public byte SysModuleVisible { get; set; }
        public string SysModuleTables { get; set; } = null!;
        public string SysModuleHooks { get; set; } = null!;
        public int SysModulePosition { get; set; }
        public int SysModuleAdmin { get; set; }
    }
}

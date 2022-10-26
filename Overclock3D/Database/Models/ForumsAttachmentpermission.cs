namespace Overclock3D.Database.Models
{
    public partial class ForumsAttachmentpermission
    {
        public uint Attachmentpermissionid { get; set; }
        public string Extension { get; set; } = null!;
        public uint Usergroupid { get; set; }
        public uint Size { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public uint Attachmentpermissions { get; set; }
    }
}

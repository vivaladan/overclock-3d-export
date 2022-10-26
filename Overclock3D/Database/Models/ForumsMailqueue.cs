namespace Overclock3D.Database.Models
{
    public partial class ForumsMailqueue
    {
        public uint Mailqueueid { get; set; }
        public uint Dateline { get; set; }
        public string? Toemail { get; set; }
        public string? Fromemail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public string? Header { get; set; }
    }
}

namespace Overclock3D.Database.Models
{
    public partial class ForumsHvanswer
    {
        public int Answerid { get; set; }
        public int Questionid { get; set; }
        public string Answer { get; set; } = null!;
        public uint Dateline { get; set; }
    }
}

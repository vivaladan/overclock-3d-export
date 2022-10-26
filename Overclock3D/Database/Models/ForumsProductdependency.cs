namespace Overclock3D.Database.Models
{
    public partial class ForumsProductdependency
    {
        public int Productdependencyid { get; set; }
        public string Productid { get; set; } = null!;
        public string Dependencytype { get; set; } = null!;
        public string Parentproductid { get; set; } = null!;
        public string Minversion { get; set; } = null!;
        public string Maxversion { get; set; } = null!;
    }
}

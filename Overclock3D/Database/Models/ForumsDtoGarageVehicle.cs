namespace Overclock3D.Database.Models
{
    public partial class ForumsDtoGarageVehicle
    {
        public uint VehicleId { get; set; }
        public uint Userid { get; set; }
        public string Name { get; set; } = null!;
        public uint Year { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Packages { get; set; } = null!;
        public string History { get; set; } = null!;
        public string Exteriormods { get; set; } = null!;
        public string Interiormods { get; set; } = null!;
        public string Icemods { get; set; } = null!;
        public string Drivetrainmods { get; set; } = null!;
        public string Suspensionmods { get; set; } = null!;
        public string Wheelsandtires { get; set; } = null!;
        public DateTime TimeModified { get; set; }
        public DateTime TimeAdded { get; set; }
        public bool? Allowcomments { get; set; }
        public bool Display { get; set; }
        public uint? Views { get; set; }
        public uint? CommentThreadId { get; set; }
    }
}

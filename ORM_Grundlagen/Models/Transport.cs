namespace ORM_Grundlagen.Models {
    public class Transport {
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string Notes { get; set; }
        public User User { get; set; }
        public Color Color { get; set; }
    }
}
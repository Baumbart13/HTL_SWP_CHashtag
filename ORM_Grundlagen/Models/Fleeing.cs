namespace ORM_Grundlagen.Models {
    public class Fleeing {
        public int Id { get; set; }
        public int NumberFugitives { get; set; }
        public string Participants { get; set; }
        public bool WasCornered { get; set; }
        public bool UsedCoercivePower { get; set; }
        public string Direction { get; set; }
    }
}
namespace ORM_Grundlagen.Models {
    public class User {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public Color Color { get; set; }
        public string Password { get; set; }
        public bool ForLogin { get; set; }
    }
}
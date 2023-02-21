using System.ComponentModel.DataAnnotations;

namespace ORM_Grundlagen.Models {
    public class Location {
        public string Name { get; set; }
        [MaxLength(4)]
        public string Postal { get; set; }
        public string exactLocation { get; set; }
    }
}
using System;

namespace ORM_Grundlagen.Models {
    public class Report {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
    }
}
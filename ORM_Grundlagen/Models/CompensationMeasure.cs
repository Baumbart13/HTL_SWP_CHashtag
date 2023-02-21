using System;
using System.Collections.Generic;

namespace ORM_Grundlagen.Models {
    public class CompensationMeasure {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string ReasonAbortion { get; set; }
        public string Notes { get; set; }
        public Police Police { get; set; }
        public Location Location { get; set; }
        public List<EventLog> EventLogs { get; set; }
    }
}
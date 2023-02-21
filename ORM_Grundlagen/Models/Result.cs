using System.Collections.Generic;

namespace ORM_Grundlagen.Models {
    
    /// <summary>
    /// Right before a shift change, a Result needs to be created
    /// containing all information of the old shift as a conclusion
    /// </summary>
    public class Result {
        public int Id { get; set; }
        public List<Location> Locations { get; set; }
        public List<CompensationMeasure> CMs { get; set; }
        public List<EventLog> EventLogs { get; set; }
        public string Notes { get; set; }
        public string Author { get; set; }
        public string TrpKdt { get; set; }
    }
}
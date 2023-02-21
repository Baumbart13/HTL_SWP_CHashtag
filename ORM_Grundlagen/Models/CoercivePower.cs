using System.Collections.Generic;

namespace ORM_Grundlagen.Models {
    public class CoercivePower {
        public int Id { get; set; }
        public List<string> FromWho { get; set; }
        public string WhoUsedClosingMeans { get; set; }
        public bool IsVictimInjured { get; set; }
        public bool WasFirearmUsed { get; set; }
        public bool wasSprayUsed { get; set; }
        public bool HasPoliceDocumented { get; set; }
        public bool WasBodyforceUsed { get; set; }
    }
}
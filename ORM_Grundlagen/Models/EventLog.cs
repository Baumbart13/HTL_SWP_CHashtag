using System;
using System.Collections.Generic;

namespace ORM_Grundlagen.Models {
    public class EventLog {
        public int Id { get; set; }
        public User Nickname { get; set; }
        public string Author { get; set; }
        public DateTime CaptureTimestamp { get; set; }
        public Location Location { get; set; }
        public string Label { get; set; }
        public string NameTrpKdt { get; set; }
        public List<string> FurtherSoldiersOnSite { get; set; }
        public List<string> FurtherPeopleOnSite { get; set; }
        public Police Police { get; set; }
        public CompensationMeasure Cm { get; set; }
        public Seize Seizes { get; set; }
        public bool IsPersonalDataRecorded { get; set; }
        public Examination Examination { get; set; }
        public bool DoesHandoverProtocolExist { get; set; }
        public bool WasGuarded { get; set; }
        public string CooperativeBehavior { get; set; }
        public CoercivePower CoercivePower { get; set; }
        public Transport MigrantTransport { get; set; }
        public string DescriptionEvent { get; set; }
        public Fleeing Fleeing { get; set; }
        public string FurtherMeasures { get; set; }
        public string Notes { get; set; }
    }
}
using System.Collections.Generic;

namespace ORM_Grundlagen.Models {
    public class Seize {
        public int Id { get; set; }
        public List<Entry> Entries { get; set; }

        public class Entry {
            private int Count { get; set; }
            public Gender Gender { get; set; }
            public bool IsChild { get; set; }
            public string Nationality { get; set; }
            public string Note { get; set; }
        }
    }
}
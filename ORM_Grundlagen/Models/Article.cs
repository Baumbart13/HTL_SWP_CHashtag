using System;

namespace ORM_Grundlagen.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        // CTors + ToString()
    }
}

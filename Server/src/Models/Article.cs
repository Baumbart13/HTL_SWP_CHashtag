using System;

namespace server.Models
{
    public class Article
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public decimal Price { get; set; } = 0.0m;
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        
        public Article(){}
    }
}
using System.Collections.Generic;

namespace ORM_Grundlagen.models
{
    public class Article
    {
        public int ArticleId { get; set; } = 0;
        public string Articlename { get; set; } = "";
        public decimal Price { get; set; }  = 0.00m;
        
        
        // NavigationsProperties
        public List<Invoice> Invoices{ get; set; }
        
        public Article(){}

        public Article(int id, string name, decimal price)
        {
            ArticleId = id;
            Articlename = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ArticleId} {Articlename} {Price}";
        }
    }
}
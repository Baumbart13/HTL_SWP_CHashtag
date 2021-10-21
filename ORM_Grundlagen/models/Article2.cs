using System.Collections.Generic;

namespace ORM_Grundlagen.models
{
    public class Article2
    {
        public int Article2Id { get; set; } = 0;
        public string Articlename { get; set; } = "";
        public decimal Price { get; set; }  = 0.00m;
        
        
        // NavigationsProperties
        public List<Invoices2Articles2> Invoices2Articles2s { get; set; }
        
        public Article2(){}

        public Article2(int id, string name, decimal price)
        {
            Article2Id = id;
            Articlename = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Article2Id} {Articlename} {Price}";
        }
    }
}
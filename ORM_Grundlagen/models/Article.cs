namespace ORM_Grundlagen.models
{
    public class Article
    {
        public int ArticleId = 0;

        public string Manufacturer = "";
        public string Articlename = "";
        public decimal Price = 0.00m;
        
        public Article(){}

        public Article(int id, string manufacturer, string name, decimal price)
        {
            ArticleId = id;
            Manufacturer = manufacturer;
            Articlename = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ArticleId} {Manufacturer} {Articlename} {Price}";
        }
    }
}
namespace ORM_Grundlagen.models
{
    public class Invoices2Articles2
    {
        public int Id { get; set; } = 0;
        
        // NavProperties
        public Invoice2 Invoice2 { get; set; }
        public Article2 Article2 { get; set; }

        // zusätzliches Feld
        public decimal EndPrice { get; set; } = 0.0m;

        public Invoices2Articles2(){}

        public Invoices2Articles2(decimal endprice)
        {
            EndPrice = endprice;
        }

        public override string ToString()
        {
            return $"{Id} {EndPrice}";
        }
    }
}
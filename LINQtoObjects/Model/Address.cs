namespace LINQtoObjects.Model
{
    public class Address
    {
        public string Street { get; init; }
        public long House { get; init; }
        public long Door { get; init; }

        public string ToString
        {
            get
            {
                return $"{Street} {House}/{Door}";
            }
        }
    }
}
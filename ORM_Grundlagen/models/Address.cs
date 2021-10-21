namespace ORM_Grundlagen.models
{
    public class Address
    {
        public int AddressId { get; set; } = 0;
        public string Postalcode { get; set; } = "";
        public string City { get; set; } = "";
        public string Street { get; set; } = "";
        public string StreetNr { get; set; } = "";
        
        // NAVIGATIONS-PROPERTY für 1:n-Verknüpfung (n-Seite)
        public Person Person { get; set; }

        public Address(){}

        public Address(int id, string postal, string city, string street, string streetNr)
        {
            AddressId = id;
            Postalcode = postal;
            City = city;
            Street = street;
            StreetNr = streetNr;
        }

        public override string ToString()
        {
            return $"{AddressId} {Postalcode} {City} {Street} {StreetNr}";
        }
    }
}
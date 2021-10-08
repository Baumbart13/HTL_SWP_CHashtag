using System.ComponentModel;
using System.Drawing;

namespace LINQtoObjects.Model
{
    
    [DefaultValue(Gender.SomeLGBTQIAPlusSheet)]
    public enum Gender
    {
        Male,
        Female,
        Trans,
        SomeLGBTQIAPlusSheet
    }
    
    public class Customer
    {
        private ulong id;
        private string fName;
        private string lName;

        public ulong CustomerId => id;
        public string FirstName => fName;
        public string LastName => lName;
        public Gender Gender { get; private set; }
        public Color Color { get; private set; }
        public PostalCode PostalCode { get; private set; }
        public Address PrivateAddress { get; private set; }
    }
}
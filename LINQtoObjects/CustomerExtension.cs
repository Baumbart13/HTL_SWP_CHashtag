using System.Collections.Generic;
using LINQtoObjects.Model;

namespace LINQtoObjects
{
    public static class CustomerExtension
    {
        
        
        private static readonly string[] lNames = new[]
        {
            "Kefer", "Laser", "Baumgartner", "Heim", "Bertoni"
        };

        private static readonly string[] fNames = new[]
        {
            "Thomas", "Tobias", "Torben", "Alexander", "Alex"
        };
        
        public static List<Customer> CreateSomeCustomers(this Customer c)
        {
            return new List<Customer>();
        }
    }
}
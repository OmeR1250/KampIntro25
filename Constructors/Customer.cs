using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Constructor worked");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
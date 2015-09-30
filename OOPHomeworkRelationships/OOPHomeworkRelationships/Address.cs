using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Address
    {
        public Address()
        {
            City = String.Empty;
            Street = String.Empty;
            Number = String.Empty;
        }
        public Address(string city, string street, string number)
        {
            City = city;
            Street = street;
            Number = number;
        }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastomerClassLibrary
{
    public class Address
    {
        public enum AddressTypeEnum
        {
            Shipping,
            Billing
        }

        public string AddressLine { get; set; }
        public string AddressLine2 { get; set; }
        public AddressTypeEnum AddressType  { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Address(string line, AddressTypeEnum addresstype, string city, string postalCode, string state, string country)
        {
            AddressLine = line;
            AddressType = addresstype;
            City = city;
            PostalCode = postalCode;
            State = state;
            Country = country;
        }
    }
   
}

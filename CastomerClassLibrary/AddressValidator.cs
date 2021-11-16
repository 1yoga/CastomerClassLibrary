using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastomerClassLibrary;

namespace CustomerClassLibrary
{
    public class AddressValidator
    {
        public static List<string> Validate(Address address)
        {
            List<string> errors = new List<string>();
            if (address.AddressLine.Length > 100)
            {
                errors.Add("AddressLine is longer than 100 char");
            }
            if ((address.AddressLine2 != null) && (address.AddressLine2.Length > 100))
            {
                errors.Add("AddressLine2 is longer than 100 char");
            }
            if (address.City.Length > 50)
            {
                errors.Add("City is longer than 50 char");
            }
            if (address.PostalCode.Length > 6)
            {
                errors.Add("Postal code is longer than 6 char");
            }
            if (address.State.Length > 20)
            {
                errors.Add("State is longer than 20 char");
            }
            if (!(address.Country == "United States" || address.Country == "Canada"))
            {
                errors.Add("Wrong country name (only United States and Canada are accepted)");
            }

            return errors;
        }
    }
}

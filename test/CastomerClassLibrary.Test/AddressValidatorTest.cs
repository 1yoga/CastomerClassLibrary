using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerClassLibrary;
using Xunit;

namespace CastomerClassLibrary.Test
{
    public class AddressValidatorTest
    {
        [Fact]

        public void ShouldBeReturnErrors()
        {
            Address address = new Address(new string('a', 101), Address.AddressTypeEnum.Shipping, new string('a', 51), "4234324235", new string('a', 21), "Russia");
            address.AddressLine2 = new string('b', 101);
            List<string> errors = AddressValidator.Validate(address);

            Assert.Equal(6, errors.Count);

            Assert.Equal("AddressLine is longer than 100 char", errors[0]);
            Assert.Equal("AddressLine2 is longer than 100 char", errors[1]);
            Assert.Equal("City is longer than 50 char", errors[2]);
            Assert.Equal("Postal code is longer than 6 char", errors[3]);
            Assert.Equal("State is longer than 20 char", errors[4]);
            Assert.Equal("Wrong country name (only United States and Canada are accepted)", errors[5]);

        }


    }
}

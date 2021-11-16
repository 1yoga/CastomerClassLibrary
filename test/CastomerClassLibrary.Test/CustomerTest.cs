using Xunit;
using System.Collections.Generic;

namespace CastomerClassLibrary.Test
{
    public class CustomerTest
    {
        [Fact]

        public void ShouldBeAbleToCreateCustomer()
        {
            Address address = new Address("Lenin St", Address.AddressTypeEnum.Billing, "Novosibirsk", "630083", "Novosibirskaya Oblast", "Russia");

            List<string> notes = new List<string> { "Note1", "Note2" };

            Customer customer = new Customer("Kazakevich", new List<Address> {address}, notes);

            Assert.Equal("Kazakevich", customer.LastName);
            Assert.Equal(notes, customer.Notes);
            Assert.Equal(new List<Address> { address }, customer.Addresses);
        }
    }
}

using Xunit;

namespace CastomerClassLibrary.Test
{
    public class AddressTest
    {
        [Fact]

        public void ShouldBeAbleToCreateAddress()
        {
            Address address = new Address("Lenin St", Address.AddressTypeEnum.Billing, "Novosibirsk", "630083", "Novosibirskaya Oblast", "Russia");
            address.AddressLine2 = "House 154";

            Assert.NotNull(address);

            Assert.Equal("Lenin St", address.AddressLine);
            Assert.Equal("House 154", address.AddressLine2);
            Assert.Equal(Address.AddressTypeEnum.Billing, address.AddressType);
            Assert.Equal("Novosibirsk", address.City);
            Assert.Equal("630083", address.PostalCode);
            Assert.Equal("Novosibirskaya Oblast", address.State);
            Assert.Equal("Russia", address.Country);

        }

        [Fact]

        public void ShouldBeValidateAdress()
        {
            
        }
    }
}

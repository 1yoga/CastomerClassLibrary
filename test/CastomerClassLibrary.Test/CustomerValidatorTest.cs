using System;
using System.Collections.Generic;
using CustomerClassLibrary;
using Xunit;

namespace CastomerClassLibrary.Test
{
    public class CustomerValidatorTest
    {
        [Fact]
        public void ShouldBeReturnErrors()
        {
            List<Address> addresses = new List<Address>();
            List<string> notes = new List<string>();
            Customer customer = new Customer(new string('a', 51), addresses, notes);
            customer.FirstName = new string('a', 51);
            customer.PhoneNumber = "4235432543252154231";
            customer.Email = "1yoga @-mail.ru.";

            List<string> errors = CustomerValidator.Validate(customer);

            Assert.Equal(6, errors.Count);

            Assert.Equal("First name is longer than 50 char", errors[0]);
            Assert.Equal("Last name is longer than 50 char", errors[1]);
            Assert.Equal("Addresses list must contain at least 1 address", errors[2]);
            Assert.Equal("Phone number is not in E.164 format", errors[3]);
            Assert.Equal("Email is not valid", errors[4]);
            Assert.Equal("Notes cannot be empty, at least 1 note must be provided", errors[5]);
        }
    }
}

using System;
using System.Collections.Generic;
using CustomerClassLibrary;
using Xunit;
using FluentValidation;
using FluentValidation.Results;

namespace CastomerClassLibrary.Test
{
    public class CustomerValidatorTest
    {
        [Fact]
        public void ShouldBeReturnErrors()
        {
            List<Address> addresses = new List<Address>();
            List<string> notes = new List<string>();
            Customer customer = new Customer(new string('b', 51), addresses, notes);
            customer.FirstName = new string('a', 51);
            customer.PhoneNumber = "0123";
            customer.Email = "petrov123-@-mail.ru.";

            CustomerValidator validator = new CustomerValidator();
            ValidationResult result = validator.Validate(customer);

            Assert.True(!result.IsValid);
            Assert.Equal(6, result.Errors.Count);

            Assert.Equal("First name should not be longer than 50 chars", result.Errors[0].ErrorMessage);
            Assert.Equal("Last name should not be null or longer than 50 chars", result.Errors[1].ErrorMessage);
            Assert.Equal("Addresses list must be not null and not empty", result.Errors[2].ErrorMessage);
            Assert.Equal("Phone number must be in E.164 format", result.Errors[3].ErrorMessage);
            Assert.Equal("Email must be valid", result.Errors[4].ErrorMessage);
            Assert.Equal("Notes list must be not null and not empty", result.Errors[5].ErrorMessage);
        }
    }
}

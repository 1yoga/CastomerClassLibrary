using System;
using System.Collections.Generic;
using CastomerClassLibrary;
using CustomerClassLibrary;
using Xunit;
using FluentValidation;
using FluentValidation.Results;

namespace CustomerClassLibrary.Test
{
    public class AddressValidatorTest
    {
        [Fact]

        public void ShouldBeReturnErrors()
        {
            Address address = new Address(new string('a', 101), Address.AddressTypeEnum.Shipping, new string('a', 51), "4234324235", new string('a', 21), "Russia");
            address.AddressLine2 = new string('b', 101);

            AddressValidator validator = new AddressValidator();
            ValidationResult result = validator.Validate(address);

            Assert.True(!result.IsValid);
            Assert.Equal(6, result.Errors.Count);

            Assert.Equal("AddressLine should not be null or longer than 100 chars", result.Errors[0].ErrorMessage);
            Assert.Equal("AddressLine2 should not be longer than 100 chars", result.Errors[1].ErrorMessage);
            Assert.Equal("City should not be null or longer than 50 chars", result.Errors[2].ErrorMessage);
            Assert.Equal("Postal code should not be null or longer than 6 chars", result.Errors[3].ErrorMessage);
            Assert.Equal("State should not be null or longer than 6 chars", result.Errors[4].ErrorMessage);
            Assert.Equal("Wrong country name (only United States and Canada are accepted)", result.Errors[5].ErrorMessage);

        }


    }
}

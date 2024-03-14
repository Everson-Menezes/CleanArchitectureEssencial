using Domain.Entities;
using Domain.Validation;
using System.Net;

namespace Domain_Test;

public class AddressTest
{
    [Fact]
    public void ValidateId_WithInvalidId_ThrowsDomainException()
    {
        // Arrange
        int invalidId = -1;
        string country = "Brazil";
        string postalCode = "12345678";

        // Act
        void Act() => new Address(invalidId, "Street", "City", "State", postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid id value!", exception.Message);
    }
    [Fact]
    public void ValidateStreet_WithNullStreet_ThrowsDomainException()
    {
        // Arrange
        string invalidStreet = null;
        string country = "Brazil";
        string postalCode = "12345678";

        // Act
        void Act() => new Address(1, invalidStreet, "City", "State", postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid street. Street is required!", exception.Message);
    }
    [Fact]
    public void ValidateCity_WithNullCity_ThrowsDomainException()
    {
        // Arrange
        string ivalidCity = null;
        string country = "Brazil";
        string postalCode = "12345678";

        // Act
        void Act() => new Address(1, "street", ivalidCity, "State", postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid city. City is required!", exception.Message);
    }
    [Fact]
    public void ValidateCity_WithTooShortCity_ThrowsDomainException()
    {
        // Arrange
        string ivalidCity = "ABC";
        string country = "Brazil";
        string postalCode = "12345678";
        // Act
        void Act() => new Address(1, "street", ivalidCity, "State", postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid city. City must have at least four (4) characters!", exception.Message);
    }
    [Fact]
    public void ValidateState_WithNullState_ThrowsDomainException()
    {
        // Arrange
        string ivalidState = null;
        string country = "Brazil";
        string postalCode = "12345678";

        // Act
        void Act() => new Address(1, "street", "City", ivalidState, postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid state. State is required!", exception.Message);
    }
    [Fact]
    public void ValidateState_WithTooShortState_ThrowsDomainException()
    {
        // Arrange
        string ivalidState = "A";
        string country = "Brazil";
        string postalCode = "12345678";

        // Act
        void Act() => new Address(1, "street", "City", ivalidState, postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid state. State must have at least two (2) characters!", exception.Message);
    }
    [Fact]
    public void ValidatePostalCode_WithNullPotalCode_ThrowsDomainException()
    {
        // Arrange
        string ivalidPostalCode = null;
        string country = "Brazil";

        // Act
        void Act() => new Address(1, "street", "City", "state", ivalidPostalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid postal code. Postal Code is required!", exception.Message);
    }
    [Fact]
    public void ValidatePostalCode__WhenCountryIsUnitedStatesPostalCodeLengthIsDifferentOfFive_ThrowsDomainException()
    {
        // Arrange
        string postalCode = "1234";
        string country = "United States";

        // Act
        void Act() => new Address(1, "street", "City", "state", postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid postal code. Postal code must have five (5) characters!", exception.Message);
    }
    [Fact]
    public void ValidatePostalCode__WhenCountryIsBrazilPostalCodeLengthIsDifferentOfEight_ThrowsDomainException()
    {
        // Arrange
        string postalCode = "1234567";
        string country = "Brazil";

        // Act
        void Act() => new Address(1, "street", "City", "state", postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid postal code. Postal code must have eight (8) characters!", exception.Message);
    }
    [Fact]
    public void ValidatePostalCode__WhenCountryIsDifferentFromBrazilOrUnitedStates_ThrowsDomainException()
    {
        // Arrange
        string postalCode = "1234567";
        string country = "Italy";

        // Act
        void Act() => new Address(1, "street", "City", "state", postalCode, country);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("The country does not have it owns postal code validation, we must contact the bussines", exception.Message);
    }
    [Fact]
    public void ValidateCountry_WithNullCountry_ThrowsDomainException()
    {
        // Arrange
        string ivalidCountry = null;
        string postalCode = "12345678";

        // Act
        void Act() => new Address(1, "Street", "City", "State", "PostalCod", ivalidCountry);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid country. Country is required!", exception.Message);
    }
    [Fact]
    public void ValidateCountry_WhenCountryLengthIsLessThanFive_ThrowsDomainException()
    {
        // Arrange
        string ivalidCountry = "ABCD";
        string postalCode = "12345678";

        // Act
        void Act() => new Address(1, "street", "City", "State", postalCode, ivalidCountry);

        // Assert
        var exception = Assert.Throws<DomainExceptionValidation>(Act);
        Assert.Equal("Invalid country. Country must have at least five (5) characters!", exception.Message);

    }
    [Fact]
    public void Constructor_WithValidParametersAndCountryIsBrazil_CreatesAddressObject()
    {
        // Arrange
        int validId = 1;
        string street = "Rua A";
        string city = "Cidade";
        string state = "Estado";
        string postalCode = "12345678";
        string country = "Brazil";

        // Act
        var address = new Address(validId, street, city, state, postalCode, country);

        // Assert
        Assert.NotNull(address);
    }
    [Fact]
    public void Constructor_WithValidParametersAndCountryIsUnitedStates_CreatesAddressObject()
    {
        // Arrange
        int validId = 1;
        string street = "A";
        string city = "Cidade";
        string state = "Estado";
        string postalCode = "12345";
        string country = "United States";

        // Act
        var address = new Address(validId, street, city, state, postalCode, country);

        // Assert
        Assert.NotNull(address);
    }
}
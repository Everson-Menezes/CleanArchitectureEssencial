using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Validation;

namespace Domain.Entities
{
    public sealed class Address
    {
        public int Id { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        // Other relevant properties for an Address

        public Address(int id, string street, string city, string state, string postalCode, string country)
        {
            ValidateId(id);
            ValidateStreet(street);
            ValidateCity(city);
            ValidateState(state);
            ValidatePostalCode(postalCode);
            ValidateCountry(country);
        }
        private void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
        private void ValidateStreet(string street)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(street), "Invalid street. Street is required!");
            Street = street;
        }
        private void ValidateCity(string city)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(city), "Invalid city. City is required!");
            DomainExceptionValidation.When(city.Length < 4, "Invalid city. City must have at least four (4) characters!");
            City = city;
        }
        private void ValidateState(string state)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(state), "Invalid state. State is required!");
            DomainExceptionValidation.When(state.Length < 2, "Invalid state. State must have at least two (2) characters!");
            State = state;
        }
        private void ValidatePostalCode(string postalCode)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(postalCode), "Invalid postal code. Postal Code is required!");
            DomainExceptionValidation.When(postalCode.Length < 5, "Invalid postal code. Postal code must have at least five (5) characters!");
            PostalCode = postalCode;
        }
        private void ValidateCountry(string country)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(country), "Invalid country. Country is required!");
            DomainExceptionValidation.When(country.Length < 5, "Invalid country. Country must have at least five (5) characters!");
            Country = country;
        }
    }
}
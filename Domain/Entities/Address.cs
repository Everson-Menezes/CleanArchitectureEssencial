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

            ValidateCountry(country);
            ValidatePostalCode(postalCode, country);
            ValidateState(state);
            ValidateCity(city);
            ValidateStreet(street);
            ValidateId(id);
        }
        private void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
        private void ValidateStreet(string street)
        {
            /*To Do
             * Acordding to the city, the street should have it owns type of validation
             * Create a street dictionar based on the city
            */
            DomainExceptionValidation.When(string.IsNullOrEmpty(street), "Invalid street. Street is required!");
            Street = street;
        }
        private void ValidateCity(string city)
        {
            /*To Do
             * Acordding to the state, the city should have it owns type of validation
             * Create a city dictionar based on the state
            */
            DomainExceptionValidation.When(string.IsNullOrEmpty(city), "Invalid city. City is required!");
            DomainExceptionValidation.When(city.Length < 4, "Invalid city. City must have at least four (4) characters!");
            City = city;
        }
        private void ValidateState(string state)
        {
            /*To Do
             * Acordding to the country, the state should have it owns type of validation
             * Create a state dictionar based on the country
            */
            DomainExceptionValidation.When(string.IsNullOrEmpty(state), "Invalid state. State is required!");
            DomainExceptionValidation.When(state.Length < 2, "Invalid state. State must have at least two (2) characters!");
            State = state;
        }
        private void ValidatePostalCode(string postalCode, string country)
        {
            /*To Do
             * Acordding to the country, the postal code should have it owns type of validation
             * Create a country dictionar
            */
            DomainExceptionValidation.When(string.IsNullOrEmpty(postalCode), "Invalid postal code. Postal Code is required!");

            switch (country)
            {
                case "United States":
                    DomainExceptionValidation.When(postalCode.Length != 5, "Invalid postal code. Postal code must have five (5) characters!");
                    break;
                case "Brazil":
                    DomainExceptionValidation.When(postalCode.Length != 8, "Invalid postal code. Postal code must have eight (8) characters!");
                    break;
                default:
                    DomainExceptionValidation.When(true, "The country does not have it owns postal code validation, we must contact the bussines");
                    break;
            }
            
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
using Domain.Validation;
using Domain.Enums;

namespace Domain.Entities
{
    public sealed class Accommodation
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Location Location { get; private set; }
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        public AccommodationType AccommodationType { get; private set; }
        // Other relevant properties for a Lodging

        public Accommodation(int id, string name, Location location, DateTime checkInDate, DateTime checkOutDate, AccommodationType accommodationType)
        {
            ValidateId(id);
            ValidateName(name);
            Location = location;
            ValidateCheckInDate(checkInDate);
            ValidateCheckOutDate(checkOutDate, checkInDate);
            AccommodationType = accommodationType;
        }
        private void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
        private void ValidateName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required!");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Name must have at least three (3) characters!");
            Name = name;
        }
        private void ValidateCheckInDate(DateTime checkInDate)
        {
            if (checkInDate == DateTime.MinValue || (checkInDate.Date >= DateTime.Today && checkInDate.Date <= DateTime.Today.AddDays(4)))
                DomainExceptionValidation.When(true, "Invalid check-in date. Check-in date must be at least four days up to now!");
        }
        private void ValidateCheckOutDate(DateTime checkOutDate, DateTime checkInDate)
        {
            if (checkOutDate == DateTime.MinValue || (checkOutDate.Date >= checkInDate.Date))
                DomainExceptionValidation.When(true, "Invalid check-out date. Check-out date must be at least one days up to check-in date!");
        }
    }
}
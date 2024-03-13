using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Reservation
    {
        public int Id { get; private set; }
        public Customer Customer { get; private set; }
        public Destination Destination { get; private set; }
        public DateTime Date { get; private set; }
        // Other relevant properties for a reservation

        public Reservation(int id, Customer customer, Destination destination)
        {
            ValidateId(id);
            Customer = customer;
            Destination = destination;
            Date = DateTime.Now;
        }
        private void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
    }
}
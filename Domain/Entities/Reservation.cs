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

        public Reservation(int id, Customer customer, Destination destination, DateTime date)
        {
            Id = id;
            Customer = customer;
            Destination = destination;
            Date = date;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Lodging
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Location Location { get; private set; }
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        // Other relevant properties for a Lodging

        public Lodging(int id, string name, Location location, DateTime checkInDate, DateTime checkOutDate)
        {
            Id = id;
            Name = name;
            Location = location;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}
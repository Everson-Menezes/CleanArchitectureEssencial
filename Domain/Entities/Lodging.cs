using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Lodging
    {
        public int Id { get; }
        public string Name { get; }
        public string Location { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        // Outras propriedades relevantes para a hospedagem

        public Lodging(int id, string name, string location, DateTime checkInDate, DateTime checkOutDate)
        {
            Id = id;
            Name = name;
            Location = location;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}
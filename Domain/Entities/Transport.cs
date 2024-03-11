using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Transport
    {
        public int Id { get; set; }
        public string Type { get; set; } // Exemplo: "Flight", "Bus", "Train", "Car Rental", etc.
        public string Company { get; set; } // Nome da empresa de transporte
        public string DepartureLocation { get; set; }
        public string DestinationLocation { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        // Outras propriedades relevantes para o transporte

        public Transport(int id, string type, string company, string departureLocation, string destinationLocation, DateTime departureDateTime, DateTime arrivalDateTime)
        {
            Id = id;
            Type = type;
            Company = company;
            DepartureLocation = departureLocation;
            DestinationLocation = destinationLocation;
            DepartureDateTime = departureDateTime;
            ArrivalDateTime = arrivalDateTime;
        }
    }
}
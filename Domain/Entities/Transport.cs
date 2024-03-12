using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public sealed class Transport
    {
        public int Id { get; private set; }
        public TransportType Type { get; private set; } 
        public string Company { get; private set; } 
        public Location DepartureLocation { get; private set; }
        public Location DestinationLocation { get; private set; }
        public DateTime DepartureDateTime { get; private set; }
        public DateTime ArrivalDateTime { get; private set; }
        // Other relevant properties for a Transport

        public Transport(int id, string type, string company, Location departureLocation, Location destinationLocation, DateTime departureDateTime, DateTime arrivalDateTime)
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
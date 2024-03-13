using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Validation;

namespace Domain.Entities
{
    public sealed class Transport
    {
        public int Id { get; private set; }
        public TransportType TransportType { get; private set; } 
        public string Company { get; private set; } 
        public Location DepartureLocation { get; private set; }
        public Location DestinationLocation { get; private set; }
        public DateTime DepartureDateTime { get; private set; }
        public DateTime ArrivalDateTime { get; private set; }
        // Other relevant properties for a Transport

        public Transport(int id, TransportType transportType, string company, Location departureLocation, Location destinationLocation, DateTime departureDateTime, DateTime arrivalDateTime)
        {
            ValidateId(id);
            TransportType = transportType;
            Company = company;
            DepartureLocation = departureLocation;
            DestinationLocation = destinationLocation;
            ValidateDepartureDateTime(departureDateTime);
            ValidateArrivalDateTime(arrivalDateTime, departureDateTime);
        }
        private void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
        private void ValidateDepartureDateTime(DateTime DepartureDateTime)
        {
            if (DepartureDateTime == DateTime.MinValue)
                DomainExceptionValidation.When(true, "Invalid departure date.");
        }
        private void ValidateArrivalDateTime(DateTime arrivalDateTime, DateTime departureDateTime)
        {
            if (arrivalDateTime == DateTime.MinValue || (arrivalDateTime >= departureDateTime))
                DomainExceptionValidation.When(true, "Invalid departure date. Arrival date must be over departure date!");
        }
    }
}
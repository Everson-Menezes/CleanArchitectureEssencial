using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Location
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; private set; }
        // Other relevant properties for a Location

        public Location(int id, string name, Address address)
        {
            ValidateId(id);
            ValidateName(name);
            Address = address;
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
    }
}
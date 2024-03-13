using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Destination
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Location Location { get; private set; }
        // Other relevant properties for a destination

        public Destination(int id, string name, Location location)
        {
            ValidateId(id);
            ValidateName(name);
            Location = location;
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
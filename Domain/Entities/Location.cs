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
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
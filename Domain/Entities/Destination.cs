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
            Id = id;
            Name = name;
            Location = location;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        // Other relevant properties for a destination

        public Destination(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }
    }
}
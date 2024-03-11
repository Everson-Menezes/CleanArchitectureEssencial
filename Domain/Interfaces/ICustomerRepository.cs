using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        // Métodos específicos para operações relacionadas a clientes, se necessário
    }
}
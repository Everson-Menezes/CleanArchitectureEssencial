using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Validation;

namespace Domain.Entities
{ 
    public sealed class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        // Other relevant properties for a customer

        public Customer(int id, string name, string email, string phone)
        {
            ValidateDomainName(name);
            ValidateDomainEmail(email);
            ValidateDomainPhone(phone);
            ValidateDomainId(id);
        }

        private void ValidateDomainName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required!");
            Name = name;
        }
        private void ValidateDomainEmail(string email)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid name. Email is required!");
            Email = email;
        }
        private void ValidateDomainPhone(string phone)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(phone), "Invalid name. Phone is required!");
            Phone = phone;
        }
        private void ValidateDomainId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
    }
}
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
        public int Document { get; set; }
        // Other relevant properties for a customer

        public Customer(int id, string name, string email, string phone, int document)
        {
            ValidateDomainName(name);
            ValidateDomainEmail(email);
            ValidateDomainPhone(phone);
            ValidateDomainId(id);
            ValidateDomainDocument(document);
        }

        private void ValidateDomainName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required!");
            DomainExceptionValidation.When(name.Length < 3, "Invalid state. State must have at least three (3) characters!");
            Name = name;
        }
        private void ValidateDomainEmail(string email)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid email. Email is required!");
            DomainExceptionValidation.When(email.Length < 13, "Invalid state. State must have at least thirteen (13) characters!");
            Email = email;
        }
        private void ValidateDomainPhone(string phone)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(phone), "Invalid phone. Phone is required!");
            DomainExceptionValidation.When(phone.Length < 11, "Invalid state. State must have at least eleven (11) characters!");
            Phone = phone;
        }
        private void ValidateDomainId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
        private void ValidateDomainDocument(int document)
        {
            DomainExceptionValidation.When(document < 9, "Invalid Document value!");
            Document = document;
        }
    }
}
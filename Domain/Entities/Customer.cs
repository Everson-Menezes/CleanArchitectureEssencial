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
            ValidateName(name);
            ValidateEmail(email);
            ValidatePhone(phone);
            ValidateId(id);
            ValidateDocument(document);
        }

        private void ValidateName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required!");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Name must have at least three (3) characters!");
            Name = name;
        }
        private void ValidateEmail(string email)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid email. Email is required!");
            DomainExceptionValidation.When(email.Length < 13, "Invalid email. Email must have at least thirteen (13) characters!");
            Email = email;
        }
        private void ValidatePhone(string phone)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(phone), "Invalid phone. Phone is required!");
            DomainExceptionValidation.When(phone.Length < 11, "Invalid phone. Phone must have at least eleven (11) characters!");
            Phone = phone;
        }
        private void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value!");
            Id = id;
        }
        private void ValidateDocument(int document)
        {
            DomainExceptionValidation.When(document < 9, "Invalid Document value!");
            Document = document;
        }
    }
}
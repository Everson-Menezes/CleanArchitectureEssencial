using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class PaymentBilling
    {
        public int Id { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public string PaymentMethod { get; private set; }
        public string Status { get; private set; }
        // Other relevant properties for a payment and billing

        public PaymentBilling(int id, decimal amount, DateTime paymentDate, string paymentMethod, string status)
        {
            Id = id;
            Amount = amount;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
            Status = status;
        }
    }
}
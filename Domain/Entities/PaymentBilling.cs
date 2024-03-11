using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class PaymentBilling
    {
        public int Id { get; }
        public decimal Amount { get; }
        public DateTime PaymentDate { get; }
        public string PaymentMethod { get; }
        public string Status { get; }
        // Outras propriedades relevantes para pagamento e faturamento

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
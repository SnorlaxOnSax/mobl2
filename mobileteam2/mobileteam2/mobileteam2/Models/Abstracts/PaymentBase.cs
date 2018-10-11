using System;

namespace mobileteam2.Models
{
    public abstract class PaymentBase
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal class BkashPayment : IPaymentProcessor, IRefundable, ITrackable, IRecurringPayment
    {
        public void processPayment(string customerId, double amount)
        {
            Console.WriteLine($"bKash: Payment of {amount} TK successful!");
        }

        public void refund(string customerName, double amount)
        {
            Console.WriteLine($"bKash: Refund of {amount} TK successful!");
        }

        public void setUpRecurring(string customerName, double amount, string frequency)
        {
            Console.WriteLine($"bKash: {frequency} recurring payment of {amount} TK setup!");
        }

        public string trackPayment(string transactionId)
        {
            return "Payment completed successfully";
        }
    }
}

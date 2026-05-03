using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal class NagadPayment : IPaymentProcessor, IRefundable, ITrackable
    {
        public void processPayment(string customerId, double amount)
        {
            Console.WriteLine($"Nagad: Payment of {amount} TK successful!");
        }

        public void refund(string customerName, double amount)
        {
            Console.WriteLine($"Nagad: Refund of {amount} TK successful!");
        }

        public string trackPayment(string transactionId)
        {
            return "Payment completed successfully";
        }
    }
}

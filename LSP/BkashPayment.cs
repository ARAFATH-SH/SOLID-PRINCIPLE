using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class BkashPayment : IPaymentProcessor, IRefundable
    {
        public void ProcessPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nProcessing payment of {amount} TK via bKash...");
            Console.WriteLine($"   bKash: Payment of {amount} TK successful!");
        }

        public void Refund(string customerName, double amount)
        {
            Console.WriteLine($"\nRefunding {amount} TK to {customerName}'s bKash account...");
            Console.WriteLine($"   bKash: Refund of {amount} TK successful!");
        }
    }
}

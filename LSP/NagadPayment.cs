using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class NagadPayment : IRefundable, IPaymentProcessor
    {
        public void ProcessPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nProcessing payment of {amount} TK via Nagad...");
            Console.WriteLine($"   Nagad: Payment of {amount} TK successful!");
        }

        public void Refund(string customerName, double amount)
        {
            Console.WriteLine($"\nRefunding {amount} TK to {customerName}'s Nagad account...");
            Console.WriteLine($"   Nagad: Refund of {amount} TK successful!");
        }
    }
}

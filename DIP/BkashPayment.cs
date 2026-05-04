using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class BkashPayment : IPaymentProcessor
    {
        public void processPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nProcessing payment of {amount} TK via bKash...");
            Console.WriteLine($"   bKash: Payment of {amount} TK successful!");
        }
    }
}

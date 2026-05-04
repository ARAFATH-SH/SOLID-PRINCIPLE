using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class NagadPayment : IPaymentProcessor
    {
        public void processPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nProcessing payment of {amount} TK via Nagad...");
            Console.WriteLine($"   Nagad: Payment of {amount} TK successful!");
        }
    }
}

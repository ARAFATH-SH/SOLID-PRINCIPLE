using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class BkashPayment : IPaymentProcessor
    {
        public void ProcessPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nProcessing payment of {amount} TK via bKash...");
            Console.WriteLine("   Connecting to bKash API...");
            Console.WriteLine($"   bKash: Payment of {amount} TK successful!");
        }
    }
}

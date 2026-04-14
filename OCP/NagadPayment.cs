using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class NagadPayment : IPaymentProcessor
    {
        public void ProcessPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nProcessing payment of {amount} TK via Nagad...");
            Console.WriteLine("   Connecting to Nagad API...");
            Console.WriteLine($"   Nagad: Payment of {amount} TK successful!");
        }
    }
}

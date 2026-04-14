using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class RocketPayment : IPaymentProcessor
    {
        public void ProcessPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nProcessing payment of {amount} TK via Rocket...");
            Console.WriteLine("   Connecting to Rocket API...");
            Console.WriteLine($"   Rocket: Payment of {amount} TK successful!");
        }
    }
}

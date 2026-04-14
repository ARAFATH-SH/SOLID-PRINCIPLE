using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class CashOnDeliveryPayment : IPaymentProcessor
    {
        public void ProcessPayment(string customerName, double amount)
        {
            Console.WriteLine($"\nCash on Delivery for {customerName}");
            Console.WriteLine($"   Amount to collect at delivery: {amount} TK");
            Console.WriteLine("   COD confirmed!");
        }

    }
}

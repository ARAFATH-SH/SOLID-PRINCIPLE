using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class PaymentService
    {
        public void ProcessPayment(string customerName, double amount) {
            Console.WriteLine($"\nProcessing payment of {amount} TK via bkash");
            Console.WriteLine("     Conecting to bkash API");
            Console.WriteLine($"    bkash: payment of {amount} TK successfull");
        }
    }
}

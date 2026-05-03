using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal class CashOnDeliveryPayment : IPaymentProcessor, ITrackable
    {
        public void processPayment(string customerId, double amount)
        {
            Console.WriteLine($"COD: {amount} TK to collect at delivery!");
        }

        public string trackPayment(string transactionId)
        {
            return "Out for delivery — payment pending";
        }
    }
}

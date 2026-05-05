using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Payments
{
    internal class CashOnDelivery : IPaymentProcessor
    {
        public void processPayment(Order order)
        {
            Console.WriteLine($"Payment done by {order.PaymentMethod}");
            Console.WriteLine($"    Total: {order.Total} Tk");
            Console.WriteLine($"    Transaction for order #{order.OrderId}\n\n");
        }
    }
}

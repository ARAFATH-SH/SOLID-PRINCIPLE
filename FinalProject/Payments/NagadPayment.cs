using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Payments
{
    internal class NagadPayment : IPaymentProcessor, IRefundable
    {
        public void processPayment(Order order)
        {
            Console.WriteLine($"Payment done by {order.PaymentMethod}");
            Console.WriteLine($"    Total: {order.Total} Tk");
            Console.WriteLine($"    Transaction for order #{order.OrderId}\n\n");
        }

        public void refund(Order order)
        {
            Console.WriteLine($"\nNagad: Refunding {order.Total} TK to {order.CustomerName}...");
            Console.WriteLine($"    Nagad: Refund successful for order #{order.OrderId}!\n\n");
        }
    }
}

using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Payments
{
    internal class BkashPayment : IPaymentProcessor, IRefundable
    {
        public void processPayment(Order order)
        {
            Console.WriteLine($"Payment done by {order.PaymentMethod}");
            Console.WriteLine($"    Total: {order.Total} Tk");
            Console.WriteLine($"    Transaction for order #{order.OrderId}\n\n");
        }

        public void refund(Order order)
        {
            Console.WriteLine($"\nbKash: Refunding {order.Total} TK to {order.CustomerName}...");
            Console.WriteLine($"    bKash: Refund successful for order #{order.OrderId}!\n\n");
        }
    }
}

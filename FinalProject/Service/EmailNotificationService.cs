using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Service
{
    internal class EmailNotificationService : INotificationService
    {
        public void sendNotification(Order order)
        {
            Console.WriteLine($"\nEmail: Sending confirmation to {order.CustomerName.ToLower()}@email.com...");
            Console.WriteLine($"   Subject: Order #{order.OrderId} confirmed!");
            Console.WriteLine($"   Body: Your order for {order.Product} ({order.Total} TK) has been confirmed.");
            Console.WriteLine("   Email sent successfully!");
        }
    }
}

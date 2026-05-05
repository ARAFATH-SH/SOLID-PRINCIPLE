using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Service
{
    internal class SmsNotificationService : INotificationService
    {
        public void sendNotification(Order order)
        {
            Console.WriteLine($"📱 SMS to {order.CustomerName}: Order #{order.OrderId} confirmed!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class EmailNotification : INotificationService
    {
        public void sendNotification(string customerName, string product)
        {
            Console.WriteLine("\nSending confirmation email...");
            Console.WriteLine($"   To: {customerName.ToLower()}@email.com");
            Console.WriteLine("   Email sent successfully!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class NotificationService
    {
        public void sendEmail(string customerName, string product)
        {
            Console.WriteLine("\nSending confirmation email...");
            Console.WriteLine("     SMTP: Connecting to mail server");
            Console.WriteLine($"    To: {customerName}@gmail.com");
            Console.WriteLine($"    Subject: Order Confirmed!");
            Console.WriteLine($"    Body: Dear {customerName}, your order for {product} has been placed.");
            Console.WriteLine("     Email sent successfully!");
        }
    }
}

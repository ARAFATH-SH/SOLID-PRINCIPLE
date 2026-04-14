using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class NotificationService
    {
        public void SendEmail(string customerName, string product)
        {
            Console.WriteLine("\nSending confirmation email...");
            Console.WriteLine($"   To: {customerName.ToLower()}@email.com");
            Console.WriteLine("   Email sent successfully!");
        }

    }
}

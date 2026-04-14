using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class NotifiactionService
    {
        public void sendEmail(string customerName, string product) {
            Console.WriteLine("\nSending confirmation email...");
            Console.WriteLine($"   To: {customerName.ToLower()}@email.com");
            Console.WriteLine("   Email sent successfully!");
        }
    }
}

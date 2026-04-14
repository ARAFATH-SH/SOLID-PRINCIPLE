using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class OrderRepository
    {
        public void Save(string customerName, string product, double total)
        {
            Console.WriteLine("\nSaving order to database...");
            Console.WriteLine($"   SQL: INSERT INTO Orders VALUES('{customerName}', '{product}', {total})");
            Console.WriteLine("   Database: Order saved successfully!");
        }
    }
}

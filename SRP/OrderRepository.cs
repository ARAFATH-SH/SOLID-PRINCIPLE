using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class OrderRepository
    {
        public void save(string customerName, string product, double total)
        {
            Console.WriteLine("\nSaving order to database...");
            Console.WriteLine($"    SQL: INSERT INTO Orders VALUES('{customerName}', '{product}', {total})");
            Console.WriteLine("     Database: Order saved successfully!");
        }
    }
}

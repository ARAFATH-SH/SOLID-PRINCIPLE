using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class InvoiceGenerator
    {
        public void Generate(string customerName, string product, double total)
        {
            Console.WriteLine("\nGenerating invoice PDF...");
            Console.WriteLine($"    Creating: Invoice_{customerName}_{product}.pdf");
            Console.WriteLine("     Adding header, items, total...");
            Console.WriteLine("     PDF generated successfully!");
        }
    }
}

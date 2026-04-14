using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class InvoiceGenerator
    {
        public void Generate(string customerName, string product, double total)
        {
            Console.WriteLine("\nGenerating invoice PDF...");
            Console.WriteLine($"   Creating: Invoice_{customerName}_{product}.pdf");
            Console.WriteLine("   PDF generated successfully!");
        }
    }
}

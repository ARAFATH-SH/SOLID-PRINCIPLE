using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class PdfGenerator : IInvoiceGenerator
    {
        public void generator(string customerName, string product, double total)
        {
            Console.WriteLine("\nGenerating invoice PDF...");
            Console.WriteLine($"   Creating: Invoice_{customerName}_{product}.pdf");
            Console.WriteLine("   PDF generated successfully!");
        }
    }
}

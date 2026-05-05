using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Service
{
    internal class PdfInvoiceGenerator : IInvoiceGenerator
    {
        public void generate(Order order)
        {
            Console.WriteLine($"\nInvoice: Generating PDF for order #{order.OrderId}...");
            Console.WriteLine($"   File: Invoice_{order.OrderId}_{order.CustomerName}.pdf");
            Console.WriteLine($"   Amount: {order.Total} TK | Payment: {order.PaymentMethod}");
            Console.WriteLine("   Invoice generated successfully!");
        }
    }
}

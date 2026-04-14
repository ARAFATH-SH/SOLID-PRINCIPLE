using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class OrderService
    {
        private NotificationService notificationService = new NotificationService();
        private PaymentService paymentService = new PaymentService();
        private InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        private OrderRepository orderRepository = new OrderRepository();

        public void createOrder(string customerName, string product, double price, int quantity) {
            double total = price * quantity;
            Console.WriteLine("\nOrder Created!");
            Console.WriteLine($"    Customer: {customerName}");
            Console.WriteLine($"    Product: {product}, Quantity: {quantity}");
            Console.WriteLine($"    Total: {total} TK");

            paymentService.ProcessPayment(customerName, total);
            orderRepository.save(customerName, product, total);
            notificationService.sendEmail(customerName, product);
            invoiceGenerator.Generate(customerName, product, total);
        }

    }
}

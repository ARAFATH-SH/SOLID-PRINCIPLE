using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class OrderService
    {
        private OrderRepository orderRepository = new OrderRepository();
        private NotifiactionService notifiactionService = new NotifiactionService();
        private InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

        public void CreateOrder(string customerName, string product, double price, int quantity, string paymentMethod)
        {
            double total = price * quantity;
            Console.WriteLine("Order Created!");
            Console.WriteLine($"   Customer: {customerName}");
            Console.WriteLine($"   Product: {product}, Quantity: {quantity}");
            Console.WriteLine($"   Total: {total} TK");

            IPaymentProcessor payment;

            if (paymentMethod == "bkash")       payment = new BkashPayment();
            else if(paymentMethod == "nagad")   payment = new NagadPayment();
            else                                payment = new RocketPayment();

            payment.ProcessPayment(customerName, total);

            orderRepository.Save(customerName, product, total);
            notifiactionService.sendEmail(customerName, product);
            invoiceGenerator.Generate(customerName, product, total);

            Console.WriteLine("\nOrder process complete!");
        }

    }
}

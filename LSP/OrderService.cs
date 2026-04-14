using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LSP
{
    internal class OrderService
    {
        private NotificationService notificationService = new NotificationService();
        private InvoiceGenerator invoice = new InvoiceGenerator();
        private OrderRepository orderRepository = new OrderRepository();

        public void CreateOrder(string customerName, string product, double price, int quantity, string paymentMethod)
        {

            double total = price * quantity;
            Console.WriteLine("Order Created!");
            Console.WriteLine($"   Customer: {customerName}");
            Console.WriteLine($"   Product: {product}, Quantity: {quantity}");
            Console.WriteLine($"   Total: {total} TK");

            IPaymentProcessor payment;

            if (paymentMethod == "Bkash") { payment = new BkashPayment(); }
            else if (paymentMethod == "Nagad") { payment = new NagadPayment(); }
            else payment = new CashOnDeliveryPayment();

            payment.ProcessPayment(customerName, total);

            orderRepository.Save(customerName, product, total);
            notificationService.SendEmail(customerName, product);
            invoice.Generate(customerName, product, total);

            Console.WriteLine("\nOrder process complete!");

        }

        public void RefundOrder(string customerName, double amount, string paymentMethod)
        {
            Console.WriteLine($"\n Processing refund for {customerName}...");

            IPaymentProcessor payment;

            if (paymentMethod == "Bkash") { payment = new BkashPayment(); }
            else if (paymentMethod == "Nagad") { payment = new NagadPayment(); }
            else payment = new CashOnDeliveryPayment();

            if (payment is IRefundable refundable)
            {
                refundable.Refund(customerName, amount);
                Console.WriteLine("Refund complete!");
            }
            else
            {
                Console.WriteLine($"{paymentMethod} does not support online refund.");
                Console.WriteLine("   Please contact customer service for manual refund.");
            }

        }
    }
}

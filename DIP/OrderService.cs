using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class OrderService
    {
        private IPaymentProcessor _processor;
        private IOrderRepository _orderRepository;
        private INotificationService _notificationService;
        private IInvoiceGenerator _invoiceGenerator;

        public OrderService(IPaymentProcessor processor, IOrderRepository orderRepository, INotificationService notificationService, IInvoiceGenerator invoiceGenerator)
        {
            _processor = processor;
            _orderRepository = orderRepository;
            _notificationService = notificationService;
            _invoiceGenerator = invoiceGenerator;
        }

        public void createOrder(string customerName, string product, double price, int quantity)
        {
            double total = price * quantity;
            Console.WriteLine("Order Created!");
            Console.WriteLine($"   Customer: {customerName}");
            Console.WriteLine($"   Product: {product}, Quantity: {quantity}");
            Console.WriteLine($"   Total: {total} TK");

            _processor.processPayment(customerName, total);
            _orderRepository.save(customerName, product, total);
            _notificationService.sendNotification(customerName, product);
            _invoiceGenerator.generator(customerName, product, total);

            Console.WriteLine("\nOrder process complete!");

        }


    }
}

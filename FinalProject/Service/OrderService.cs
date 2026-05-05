using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Service
{
    internal class OrderService
    {
       
        private IPaymentProcessor paymentProcessor;
        private INotificationService notificationService;
        private IRepository<Order> repository;
        private IInvoiceGenerator invoiceGenerator;

        public OrderService(IPaymentProcessor paymentProcessor, INotificationService notificationService, IRepository<Order> repository, IInvoiceGenerator invoiceGenerator)
        {
            this.paymentProcessor = paymentProcessor;
            this.notificationService = notificationService;
            this.repository = repository;
            this.invoiceGenerator = invoiceGenerator;
        }

        public Order PlaceOrder(string customerName, string product, double price, int quantity, string paymentMethod)
        {
           
            Console.WriteLine("NEW ORDER");
            

            Order order = new Order
            {
                OrderId = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                CustomerName = customerName,
                Product = product,
                Price = price,
                Quantity = quantity,
                Total = price * quantity,
                PaymentMethod = paymentMethod,
                OrderDate = DateTime.Now
            };

            Console.WriteLine($"\nOrder #{order.OrderId} Created!");
            Console.WriteLine($"   Customer: {order.CustomerName}");
            Console.WriteLine($"   Product: {order.Product} x{order.Quantity}");
            Console.WriteLine($"   Total: {order.Total} TK");
            Console.WriteLine($"   Payment: {order.PaymentMethod}");

            paymentProcessor.processPayment(order);
            repository.Add(order);
            notificationService.sendNotification(order);
            invoiceGenerator.generate(order);

            Console.WriteLine("\nOrder process complete!");

            return order;
        }

        public void refundOrder(string orderId)
        {
            Console.WriteLine("Refund request");

            Order order = repository.getById(orderId);

            if(order == null)
            {
                Console.WriteLine($"Order #{orderId} not found!");
                return;
            }

            if(paymentProcessor is IRefundable refundable)
            {
                refundable.refund(order);
                Console.WriteLine($"Order #{orderId} not found!");
            }
            else
            {
                Console.WriteLine($"{order.PaymentMethod} does not support online refund.");
                Console.WriteLine("   Please contact customer service for manual refund.");
            }

        }

        public void showAllOrders()
        {
            Console.WriteLine("All Order");
            List<Order> orders = repository.getAll();

            if(orders.Count == 0)
            {
                Console.WriteLine("\n   No orders yet!");
            }
            else
            {
                foreach (Order order in orders)
                {
                    Console.WriteLine($"{order.OrderId} - {order.OrderDate: dd MMM yyyy}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal class OrderService
    {
        public void createOrder(string customerName, string product, double price, int quantity, string paymentMethod)
        {
            double total = price * quantity;
            Console.WriteLine($"Order: {customerName} - {product} - {total} Tk");

            IPaymentProcessor payment;

            if (paymentMethod == "bkash") payment = new BkashPayment();
            else if (paymentMethod == "nagad") payment = new NagadPayment();
            else payment = new CashOnDeliveryPayment();

            payment.processPayment(customerName, total);
        }

        public void refundOrder(string customerName, double amount, string paymentMethod)
        {
            Console.WriteLine($"Refund for {customerName}...");

            IPaymentProcessor payment;
            if (paymentMethod == "bkash") payment = new BkashPayment();
            else if (paymentMethod == "nagad") payment = new NagadPayment();
            else payment = new CashOnDeliveryPayment();

            if (payment is IRefundable refundable)
            {
                refundable.refund(customerName, amount);
            }
            else
            {
                Console.WriteLine($"{paymentMethod} does not support refund");
            }

        }

        public void setUpAutoPayment(string customerName, double amount, string frequency, string paymentMethod)
        {
            Console.WriteLine($"Auto-Payment for {customerName}...");

            IPaymentProcessor payment;
            if (paymentMethod == "bkash") payment = new BkashPayment();
            else if (paymentMethod == "nagad") payment = new NagadPayment();
            else payment = new CashOnDeliveryPayment();

            if(payment is IRecurringPayment recurringPayment)
            {
                recurringPayment.setUpRecurring(customerName, amount, frequency);
            }
            else
            {
                Console.WriteLine($"{paymentMethod} does not support recurring payments.");
            }
        }
    }
}
using FinalProject.Interfaces;
using FinalProject.Model;
using FinalProject.Payments;
using FinalProject.Repositories;
using FinalProject.Service;
using System.ComponentModel.DataAnnotations;

public class Program
{
    static void Main()
    {
        IRepository<Order> repository = new InMemoryOrderRepository();
        INotificationService emailNotification = new EmailNotificationService();
        IInvoiceGenerator pdf = new PdfInvoiceGenerator();

        Dictionary<String, IPaymentProcessor> paymentMethods =new()
        {
            {"bkash", new BkashPayment() },
            {"nagad", new NagadPayment() },
            {"cod", new CashOnDelivery() }
        };

        //for bkash
        IPaymentProcessor bkashPayment = paymentMethods["bkash"];
        OrderService bkashOrder = new OrderService(bkashPayment, emailNotification, repository, pdf);

        Order order1 = bkashOrder.PlaceOrder("Arafath", "Ipad", 45000, 1, "bkash");

        //for Nagad
        IPaymentProcessor nagadPayment = paymentMethods["nagad"];
        OrderService nagadOrder = new OrderService(nagadPayment, emailNotification, repository, pdf);

        Order order2 = nagadOrder.PlaceOrder("Shihab", "Ipad", 45000, 1, "bkash");

        //For COD

        IPaymentProcessor codPayment = paymentMethods["cod"];
        OrderService codOrder = new OrderService(codPayment, emailNotification, repository, pdf);

        Order order3 = codOrder.PlaceOrder("uthsob", "Ipad", 45000, 1, "bkash");

        //Show All data

        bkashOrder.showAllOrders();

        //refund
        codOrder.refundOrder(order3.OrderId);

        bkashOrder.refundOrder(order1.OrderId);
    }
}
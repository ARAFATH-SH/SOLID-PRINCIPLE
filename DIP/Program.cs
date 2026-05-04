using DIP;

public class Program
{
    static void Main()
    {
        IPaymentProcessor bkashPayment = new BkashPayment();
        IOrderRepository order = new OrderRepository();
        INotificationService notify = new EmailNotification();
        IInvoiceGenerator invoice = new PdfGenerator();

        OrderService service = new OrderService(bkashPayment, order, notify, invoice);

        service.createOrder("Arafath", "Iphone 15", 45000, 1);

        //payment change nagadpayment

        IPaymentProcessor nagadPayment = new NagadPayment();
        OrderService service2 = new OrderService(nagadPayment, order, notify, invoice);
        service2.createOrder("Shihab", "Samsung S24", 120000, 1);

    }
}
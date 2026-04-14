using LSP;

//List<IPaymentProcessor> paymentProcessors = new List<IPaymentProcessor>();
//paymentProcessors.Add(new BkashPayment());
//paymentProcessors.Add(new NagadPayment());
//paymentProcessors.Add(new CashOnDeliveryPayment());

//List<IRefundable> refundables = new List<IRefundable>();
//refundables.Add(new BkashPayment());
//refundables.Add(new NagadPayment());

//foreach(IPaymentProcessor payment in paymentProcessors)
//{
//    payment.ProcessPayment("Arafath", 10000);
//}

//foreach(IRefundable refundable in refundables)
//{
//    refundable.Refund("Arafath", 10000);
//}

OrderService order = new OrderService();

order.CreateOrder("Arafath", "Ipad", 45000, 1, "cashondelivery");

order.RefundOrder("Arafath", 45000, "cashondelivery");
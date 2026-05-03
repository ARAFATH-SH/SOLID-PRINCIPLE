using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal interface IPaymentProcessor
    {
        void processPayment(string customerId, double amount);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal interface IPaymentProcessor
    {
        void processPayment(string customerName, double amount);
    }
}

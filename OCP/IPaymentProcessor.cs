using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(string customerName, double amount);
    }
}

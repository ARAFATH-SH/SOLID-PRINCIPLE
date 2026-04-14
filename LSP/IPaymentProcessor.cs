using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(string customerName, double amount);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Model;

namespace FinalProject.Interfaces
{
    internal interface IPaymentProcessor
    {
        void processPayment(Order order);
    }
}

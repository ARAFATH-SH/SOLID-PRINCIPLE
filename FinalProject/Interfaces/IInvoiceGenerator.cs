using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Interfaces
{
    internal interface IInvoiceGenerator
    {
        void generate(Order order);
    }
}

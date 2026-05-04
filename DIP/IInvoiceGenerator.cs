using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal interface IInvoiceGenerator
    {
        void generator(string customerName, string product, double total);
    }
}


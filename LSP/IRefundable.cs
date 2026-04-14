using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal interface IRefundable
    {
        void Refund(string customerName, double amount);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal interface IRefundable
    {
        void refund(string customerName, double amount);
    }
}

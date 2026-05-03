using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal interface IRecurringPayment
    {
        void setUpRecurring(string customerName, double amount, string frequency);
    }
}

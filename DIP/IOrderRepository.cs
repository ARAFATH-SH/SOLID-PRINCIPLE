using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal interface IOrderRepository
    {
        void save(string customerName, string product, double total);
    }
}

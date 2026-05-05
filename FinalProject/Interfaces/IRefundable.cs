using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Model;

namespace FinalProject.Interfaces
{
    internal interface IRefundable
    {
       void refund(Order order);
    }
}

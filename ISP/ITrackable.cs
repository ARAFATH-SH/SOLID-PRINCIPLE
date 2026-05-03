using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal interface ITrackable
    {
        string trackPayment(string transactionId);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal interface INotificationService
    {
        void sendNotification(string customerName, string product);
    }
}

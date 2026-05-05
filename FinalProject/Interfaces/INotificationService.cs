using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Interfaces
{
    internal interface INotificationService
    {
        void sendNotification(Order order);
    }
}

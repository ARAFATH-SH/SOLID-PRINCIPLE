using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Model
{
    internal class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }

    }
}

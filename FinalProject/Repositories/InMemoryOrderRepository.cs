using FinalProject.Interfaces;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Repositories
{
    internal class InMemoryOrderRepository : IRepository<Order>
    {
        List<Order> orders = new List<Order>();
        public void Add(Order order)
        {
            orders.Add(order);
            Console.WriteLine($"\nDatabase: Order #{order.OrderId} saved!\n");
        }

        public List<Order> getAll()
        {
            Console.WriteLine($"\nDatabase: Returning all {orders.Count} orders");
            return orders;
        }

        public Order getById(string id)
        {
            Order order = orders.Find(o => o.OrderId == id);
            if ( order != null)
            {
                Console.WriteLine($"\nDatabase: Found order #{id}");
            }
            else
            {
                Console.WriteLine($"\nDatabase: Order #{id} not found!");
            }
            return order;
        }

 
    }
}

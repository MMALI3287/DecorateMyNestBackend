using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class OrderRepo : Repo, IRepo<Order, int, Order>
    {
        public Order Create(Order obj)
        {
            contextDb.Orders.Add(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var order = Read(id);
            contextDb.Orders.Remove(order);
            return contextDb.SaveChanges() > 0;
        }

        public List<Order> Read()
        {
            return contextDb.Orders.ToList();
        }

        public Order Read(int id)
        {
            return contextDb.Orders.Find(id);
        }

        public Order Update(Order obj)
        {
            var extOrder = Read(obj.OrderId);
            contextDb.Entry(extOrder).CurrentValues.SetValues(obj);
            if (contextDb.SaveChanges() > 0) return obj;
            return null;
        }
    }
}

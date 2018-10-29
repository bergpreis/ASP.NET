using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch10_CompletingTheCart.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}

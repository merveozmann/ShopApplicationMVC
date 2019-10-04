using Microsoft.EntityFrameworkCore;
using ShopApplication.DataAccess.Abstract;
using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApplication.DataAccess.Concrete.EfCore
{
    public class EfCoreOrderDal : EfCoreGenericRepository<Order, ShopContext>, IOrderDal
    {
        public List<Order> GetOrders(string userId)
        {
            using (var context=new ShopContext())
            {
                var orders = context.Orders
                    .Include(i => i.OrderItems)
                    .ThenInclude(i => i.Product)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(userId))
                {
                    orders = orders.Where(i => i.userId == userId);
                }
                return orders.ToList();
            }
        }
    }
}

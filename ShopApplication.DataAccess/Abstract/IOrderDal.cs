using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApplication.DataAccess.Abstract
{
    public interface IOrderDal : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}

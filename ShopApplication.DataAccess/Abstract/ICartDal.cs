using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApplication.DataAccess.Abstract
{
    public interface ICartDal : IRepository<Cart>
    {
        Cart GetCartByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
        void ClearCart(string cartId);
    }
}

using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApplication.DataAccess.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        Category GetByIdWithProducts(int id);
        void DeleteFromCategory(int categoryId, int productId);
    }
}

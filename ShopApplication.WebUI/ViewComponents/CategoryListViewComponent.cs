using Microsoft.AspNetCore.Mvc;
using ShopApplication.Business.Abstract;
using ShopApplication.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.WebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            return View(new CategoryListViewModel() {
                SelectedCategory=RouteData.Values["category"]?.ToString(),
                Categories=_categoryService.GetAll()
            });
        }
    }
}

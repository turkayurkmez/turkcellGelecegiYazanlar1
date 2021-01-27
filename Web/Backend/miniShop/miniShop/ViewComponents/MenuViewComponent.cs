using Microsoft.AspNetCore.Mvc;
using miniShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private ICategoryService categoryService;

        public MenuViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }


        public IViewComponentResult Invoke()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }
    }
}

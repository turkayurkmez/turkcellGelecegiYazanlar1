using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using miniShop.Models;
using miniShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    [Authorize(Roles ="Admin,Editor")]
    public class ProductsController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            
        }
        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            List<SelectListItem> selectListItems = getCategoriesForSelect();

            ViewBag.Items = selectListItems;

            return View();
        }     

      

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }

            List<SelectListItem> selectListItems = getCategoriesForSelect();
            ViewBag.Items = selectListItems;
            return View();
        }


        public IActionResult Edit(int id)
        {
            var existingProduct = productService.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            ViewBag.Items = getCategoriesForSelect();
            return View(existingProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
               int affectedRowsCount = productService.EditProduct(product);
                string message = affectedRowsCount > 0 ? $"{product.Name} isimli ürün güncellendi :)" : "Ne yazık ki bir problem oluştu :(";

                return Json(message);
            }
            ViewBag.Items = getCategoriesForSelect();
            return View();

        }

        private List<SelectListItem> getCategoriesForSelect()
        {
            var categories = categoryService.GetCategories();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            categories.ToList().ForEach(category => selectListItems.Add(new SelectListItem
            {
                Text = category.Name,
                Value = category.Id.ToString()
            }));
            return selectListItems;
        }

    }
}

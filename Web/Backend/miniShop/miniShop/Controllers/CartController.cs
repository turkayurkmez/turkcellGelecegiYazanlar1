using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using miniShop.Models;
using miniShop.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    public class CartController : Controller
    {
        private IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index(string returnUrl)
        {
            var cart = GetCart();
            ViewBag.ReturnUrl = returnUrl;
            return View(cart);
        }
        [HttpPost]
        public IActionResult AddToCart(int id, string returnUrl)
        {
            var selectedProduct = productService.GetProductById(id);
            if (selectedProduct == null)
            {
                return NotFound();
            }

            Cart cart = GetCart() ?? new Cart();
            cart.AddItem(selectedProduct, 1);
            SaveCart(cart);
            return RedirectToAction(nameof(Index),nameof(Cart),new { returnUrl=returnUrl  } );
        }

        Cart GetCart()
        {
            var data = HttpContext.Session.GetString("sepetim");
            if (data == null)
            {
                return null;
            }
            else
            {
                return JsonConvert.DeserializeObject<Cart>(data);
            }


        }

        void SaveCart(Cart cart)
        {
            HttpContext.Session.SetString("sepetim", JsonConvert.SerializeObject(cart));

        }

    }
}

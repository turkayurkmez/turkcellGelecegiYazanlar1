using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Türkay";
            ViewBag.Hour = DateTime.Now.Hour;

            List<string> products = new List<string>();
            products.Add("Pizza");
            products.Add("Cola");
            products.Add("tahin helvası :)");

            ViewBag.Products = products;

            return View();
        }
    }
}

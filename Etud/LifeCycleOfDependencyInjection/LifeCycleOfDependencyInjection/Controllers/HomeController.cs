using LifeCycleOfDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ISingletonGuidGenerator singleton;
        private IScopedGuidGenerator scoped;
        private ITransientGuidGenerator transient;
        private GuidService guidService;
        public HomeController(ILogger<HomeController> logger, ISingletonGuidGenerator singleton, IScopedGuidGenerator scoped, ITransientGuidGenerator transient, GuidService guidService)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
            this.guidService = guidService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = singleton.GeneratedGuid.ToString();
            ViewBag.Scoped = scoped.GeneratedGuid.ToString();
            ViewBag.Transient = transient.GeneratedGuid.ToString();

            ViewBag.ServiceSingleton = guidService.SingletonGuid.GeneratedGuid.ToString();
            ViewBag.ServiceScoped = guidService.ScopedGuidGenerator.GeneratedGuid.ToString();
            ViewBag.ServiceTransient= guidService.TransientGuidGenerator.GeneratedGuid.ToString();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using miniShop.Models;
using miniShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    public class AccountController : Controller
    {
        private IUserService userService;

        public IActionResult Index()
        {
            return View();
        }

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel userLoginModel, string returnUrl)
        {
            var user = userService.ValidUser(userLoginModel.UserName, userLoginModel.Password);
            if (user != null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, user.Name));
                claims.Add(new Claim(ClaimTypes.Role, user.Role.Name));


                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                return Redirect("/");
            }


            ModelState.AddModelError("hata", "Kullanıcı ya da şifre yanlış");
            return View();

        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}

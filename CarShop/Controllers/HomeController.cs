using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Error(string? url)
            {
                if (url == null)
                {
                    url = "/";
                }
                return View("Error404", url);
            }
        }
    }
}

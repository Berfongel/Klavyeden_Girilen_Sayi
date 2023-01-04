using Microsoft.AspNetCore.Mvc;
using SayiGecerliGecerliDegilWebApplication.Models;
using System.Diagnostics;

namespace SayiGecerliGecerliDegilWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(GecerliGecerliDegil gecerliGecerliDegil)
        {
            var sayi_ = gecerliGecerliDegil.Sayi;
            var message = string.Empty;
            if (sayi_ >= 0 && sayi_ <= 100 ) 
            {
                message="0-100 arasında olduğundan sayı geçerlidir.";
            }
            else
            {
                message = "0-100 arasında olmadığından sayı geçerli değildir.";
            }

            ViewBag.Message = message;
            return View("gecerliGecerliDegil");
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
using KlavyeGirilenSayiWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KlavyeGirilenSayiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(KlavyeGirilenSayi klavyeGirilenSayi)
        {
            var sayi_ = klavyeGirilenSayi.Sayi;
            int n;
            int kareleri = 0;
            int carpim = 1;
            int toplam = 0;
            for (n = 1; n <= sayi_; n++)
            {
                //2 ile bölünmüyorsa tek sayıdır
                if (n % 2 != 0)
                {
                    //örneğin ekrana girilen sayı 5 ise
                    //1
                    //1+3
                    //1+3+5 olarak alıyor
                    toplam = toplam + n;
                    //tek sayıları bulup çarpıyor.
                    //1*3*5
                    carpim = carpim * n;
                    ViewBag.Message1 = "Tek Sayıların Toplamı : " + toplam + " " + " Tek Sayıların Çarpımı : " + carpim;
                }
                else
                {
                    //2 ile bölünüyorsa çift sayıların kareleri toplamı
                    kareleri = kareleri + n * n;
                    ViewBag.Message2 = "Çift Sayıların Kareleri Toplamı : " + kareleri;

                }

            }
                return View("klavyeGirilenSayi");
            
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
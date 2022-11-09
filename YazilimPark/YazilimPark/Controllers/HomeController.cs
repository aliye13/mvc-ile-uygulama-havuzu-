using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YazilimPark.Models;

namespace YazilimPark.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new List<Applications>();

            model.Add(new Applications { applicationName = "Vücut Kütle İndeksi Hesaplama Uygulaması", image = "vkihu.png", applicationController = "BodyMassIndexCalculator", applicationAction = "Index" });
            model.Add(new Applications { applicationName = "Rastgele Özlü Söz Uygulaması", image = "rosu.png" , applicationController=" RandomQuotations", applicationAction =" Index"});
            model.Add(new Applications { applicationName = "Yapılacaklar Listesi Uygulaması", image = "ylu.png", applicationController=" ToDoList", applicationAction="Index" });
            model.Add(new Applications { applicationName = "Hava Durumu Tahmin Etme Uygulaması", image = "hdtu.png", applicationController=" ", applicationAction=" Index" });
            return View(model);
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

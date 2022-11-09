using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimPark.Models;

namespace YazilimPark.Controllers
{
    public class ApplicationsController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Applications>();
            model.Add(new Applications { applicationName = "Vücut Kütle İndeksi Hesaplama Uygulaması", image ="vkihu.png", applicationController= "BodyMassIndexCalculator" , applicationAction="Index" });
            model.Add(new Applications { applicationName = "Rastgele Özlü Söz Uygulaması", image = "rosu.png" });
            model.Add(new Applications { applicationName = "Yapılacaklar Listesi Uygulaması", image = "ylu.png" });
            model.Add(new Applications { applicationName = "Hava Durumu Tahmin Etme Uygulaması", image = "hdtu.png" });
            model.Add(new Applications { applicationName = "Rastgele Özlü Söz Uygulaması", image = "rosu.png" });
            model.Add(new Applications { applicationName = "Yapılacaklar Listesi Uygulaması", image = "ylu.png" });
            model.Add(new Applications { applicationName = "Hava Durumu Tahmin Etme Uygulaması", image = "hdtu.png" });
            return View(model);
        }
    }
}

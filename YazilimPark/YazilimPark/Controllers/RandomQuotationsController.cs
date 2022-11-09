using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimPark.Models;

namespace YazilimPark.Controllers
{
    // /api/RandomQuotations
    [Route("api/[controller]")]
    [ApiController]
    public class RandomQuotationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       

        RandomQuotations[] quotations = new RandomQuotations[]
       {
            new RandomQuotations { RQ_ID=1, Quotation="deneme"},
            new RandomQuotations { RQ_ID=2, Quotation="deneme2"},
            new RandomQuotations { RQ_ID=3, Quotation="deneme3"},
            new RandomQuotations { RQ_ID=4, Quotation="deneme4"},
            new RandomQuotations { RQ_ID=5, Quotation="deneme5"},
            new RandomQuotations { RQ_ID=6, Quotation="deneme6"},
            new RandomQuotations { RQ_ID=7, Quotation="deneme7"},
            new RandomQuotations { RQ_ID=8, Quotation="deneme8"},
            new RandomQuotations { RQ_ID=9, Quotation="deneme9" },
            new RandomQuotations { RQ_ID=10,Quotation="deneme10" },
       };
 

        public IEnumerable<RandomQuotations> GetAllQuotations()
        {
            return quotations;
        }

        public System.Web.Http.IHttpActionResult GetQuotations(int id)
        {
            var quotation = quotations.FirstOrDefault((p) => p.RQ_ID == id);
            if (quotation == null)
            {
                return (System.Web.Http.IHttpActionResult)NotFound();
            }
            return (System.Web.Http.IHttpActionResult)Ok(quotation);
        }




    }
}

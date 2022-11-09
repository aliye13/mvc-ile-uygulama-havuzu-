using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimPark.Models;

namespace YazilimPark.Controllers
{
    public class BodyMassIndexCalculatorController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
         


        /*
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string weight, string size)
        {



            float a = float.Parse(weight);
            float b = float.Parse(size);
            //double a = Convert.ToDouble(weight);
            // double b = Convert.ToDouble(size);
            float result = a / (b * b);
            ViewBag.result = result;
            return View();
        }

        */

        /* Ajax olmadan */
        [HttpPost]
        public IActionResult Index(string weight, string size)
        {
          
            float a = float.Parse(weight);
            float b = float.Parse(size);
            float result = a / (b * b);
            string indexGroup;
            if (result <= 20)
            {
                indexGroup = "Zayıf";
            }
            else if (result > 20 && result <= 29.9)
            {
                indexGroup = "Hafif Şişman";
            }
            else if (result > 30 && result <= 34.9)
            {
                indexGroup = "Sağlık Açısından Tehlikeli";
            }
            else if (result > 35 && result <= 44.9)
            {
                indexGroup = "Aşırı Şişman";
            }
            else
            {
                indexGroup = "Ölümcül Şişman";
            }

            ViewBag.result = result;
            ViewBag.IndexGroup = indexGroup;
            return View();
        }



        /*
        [HttpPost]
        public JsonResult bmiCalculate(string size, string weight)
        {
            float a = float.Parse(size);
            float b = float.Parse(weight);
            BodyMassIndexCalculator bmi = new BodyMassIndexCalculator();
            bmi.Size = a;
            bmi.Weight = b;
            bmi.Result = a / (b * b);
            return Json(bmi.Result);
        }
*/
        /* Ajax metodu */
        /*
        [HttpPost]
        public JsonResult bmiCalculate(string weight, string size)
        {
          
            float a = float.Parse(weight);
            float b = float.Parse(size);
            BodyMassIndexCalculator bmi = new BodyMassIndexCalculator();
            bmi.Size = a;
            bmi.Weight = b;
            bmi.Result = a / (b * b);
            if (bmi.Result <= 20)
            {
                bmi.IndexGroup = "Zayıf";
            }
            else if (bmi.Result >= 20 && bmi.Result <= 29.9)
            {
                bmi.IndexGroup = "Hafif Şişman";
            }
            else if (bmi.Result >= 30 && bmi.Result <= 34.9)
            {
                bmi.IndexGroup = "Sağlık Açısından Tehlikeli";
            }
            else if (bmi.Result >= 35 && bmi.Result <= 44.9)
            {
                bmi.IndexGroup = "Aşırı Şişman";
            }
            else
            {
                bmi.IndexGroup = "Ölümcül Şişman";
            }

            return Json(bmi.Result); 

        }*/



    }
}

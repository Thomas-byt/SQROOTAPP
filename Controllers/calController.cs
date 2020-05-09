using System;
using Microsoft.AspNetCore.Mvc;

namespace Calculatorweb.Controllers{
    public class CalController : Controller
    {   
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
         public ActionResult Add(string firstNumber, string secondNumber){
         //These are the user inputs
         ViewBag.firstNumber = firstNumber;
         ViewBag.secondNumber = secondNumber;
         //check to ensure the user enters a number
         int No1 = 0;
         bool isConverted1 = int.TryParse(firstNumber, out No1);

         int No2 = 0;
         bool isConverted2 = int.TryParse(firstNumber, out No2);

         //convert user input to the square root
         int SQNo1 = (int) Math.Sqrt(No1);
         int SQNo2 = (int) Math.Sqrt(No2);

         //pass the sqaure to the webpage through a viewbag
         ViewBag.SQNo1 = SQNo1;
         ViewBag.SQNo2 = SQNo2;

         ViewBag.isConverted1 = isConverted1;
         ViewBag.isConverted2 = isConverted2;

         ViewBag.No1 =No1;
         ViewBag.No2 = No2;
         return View();
         }
    }
}    
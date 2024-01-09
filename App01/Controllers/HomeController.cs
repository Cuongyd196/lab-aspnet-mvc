using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PhepTinh()
        {
            ViewBag.Message = "Phép tính";

            return View();
        }

        [HttpPost]
        public ActionResult PhepTinh(int soA, int soB, string pheptinh)
        {

            int result = 0;
            switch(pheptinh)
            {
                case "+":
                    result = soA + soB;
                    break;
                case "-":
                    result = soA - soB;
                    break;
                case "*":
                    result = soA * soB;
                    break;
                case "/":
                    result = soA / soB;
                    break;
            }    
            ViewBag.result = "Kết quả phép tính là: " +  result;
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FPSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int AddResult = Add(20, 40);
            int SubtractResult = Subtract(50, 20);
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

        public int Add(int a, int b)
        {
            int x = a + b;
            return x;

        }

        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;
        }


    }
}
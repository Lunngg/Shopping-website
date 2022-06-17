using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT_WEB_ADMIN.Models;

namespace PROJECT_WEB_ADMIN.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult AddProduct()
        {
            return View();
        }




        public ActionResult Dashboard()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }







    }
}
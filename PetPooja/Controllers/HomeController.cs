using System;
using System.Collections.Generic;
using System.Web;

using System.Web.Mvc;

namespace PetPooja.Controllers
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

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmptyMVC.Controllers
{
    public class HomeController : Controller
    {
        // how to past data from controller to view using viewbag dynamically
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FirstName = "My Fist MVC";
            ViewBag.LastName = "Andropov";
            ViewBag.Address = "Molyko-Buea";
            return View();
        }
    }
}
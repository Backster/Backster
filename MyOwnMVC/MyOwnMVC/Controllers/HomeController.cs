using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyOwnMVC.Models;

namespace MyOwnMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.DateAndTime = DateTime.Now;
            ViewBag.Error = "Error!!";
            
            return View();
            
        }

    }
}
 
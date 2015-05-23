using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyOwnMVC.Models;

namespace MyOwnMVC.Controllers
{
    public class TestareaController : Controller
    {
        // GET: Testarea
        public ActionResult Test1()
        {
            ViewBag.DateAndTime = DateTime.Now;
            
            

            Auth objCredential = new Auth();

            objCredential.FirstName = Request.Form["Fn"].ToString();
            objCredential.Password = Request.Form["Pw"].ToString();

            if (objCredential.FirstName != "Christian" || objCredential.Password != "Roulund")
            {
                
                
            }
            ViewBag.Error = "Error!!";
            return View(objCredential);
            
        }

 
    }
}
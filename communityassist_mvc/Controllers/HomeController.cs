using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using communityassist_mvc.Models; // reference to model

namespace communityassist_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Community_AssistEntities db = new Community_AssistEntities();//initialize entities classes

            return View(db.GrantTypes.ToList()); // pass the collection grants to the index as a list
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
    }
}
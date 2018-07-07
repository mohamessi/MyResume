using MyResume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyResume.Database;

namespace MyResume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Resume(string username)
        {
            ResumeModel resume = null;

            if (username.Equals("mohamed"))
            {
                resume = DbInitializer.Mohamed();
            }
            return View(resume);
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
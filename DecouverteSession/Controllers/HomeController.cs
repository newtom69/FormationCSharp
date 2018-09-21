using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteSession.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.Session["MaVariable"] = 10;


            return View();
        }

        public ActionResult About()
        {
            if (this.Session["MaVariable"] == null) this.Session["MaVariable"] = 10;

            this.Session["MaVariable"] = (int) this.Session["MaVariable"] +1;
            ViewBag.uneVariable = this.Session["MaVariable"];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
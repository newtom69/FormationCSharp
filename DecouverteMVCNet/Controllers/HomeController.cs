using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteMVCNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.DateHeure = DateTime.Now;

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
                        ViewBag.MessageTom = "popopopopopop";
                        return View();
                    }
                    public ActionResult Thomas()
                    {
                        ViewBag.Message = "Your Thomas page.";
                        return View();
                    }
                }
            }
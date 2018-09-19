using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using JeuDroides.Core.Models;

namespace DecouverteMVCNet.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {
            Paragraphe leParagraphe = new Paragraphe();
            leParagraphe.Initialiser();
            this.ViewBag.LeParagraphe = leParagraphe;

            return View();
        }
    }
}
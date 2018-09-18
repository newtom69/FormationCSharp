using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteMVCNet.Controllers
{
    public class DroideController : Controller
    {
        // GET: Droide
        public ActionResult Index()
        {

            List<int> maListeEntiers = new List<int>();
            maListeEntiers.Add(12);
            maListeEntiers.Add(33);
            maListeEntiers.Add(-7);
            ViewBag.MaListe = maListeEntiers;
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DecouverteAddEntities.Models;

namespace DecouverteAddEntities.Controllers
{
    public class DroideController : Controller
    {
        // GET: Droide
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajouter()
        {

            return View(new Droide());
        }

        [HttpPost]
        public ActionResult Ajouter(Droide droide)
        {
            using (JeuDroidesFormationEntities context = new JeuDroidesFormationEntities())
            {
                context.Troide.Add(droide);
                context.SaveChanges();

            }
                return View(droide);
        }
    }
}
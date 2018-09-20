using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JeuDroides.Core.Models;

namespace ChallengeMvcNet.Controllers
{
    public class DroideController : Controller
    {
        // GET: Droide
        public ActionResult Index()
        {
            char PremiereLettre = 't';
            this.ViewBag.laPremiereLettre = PremiereLettre;
            PopulationDroides laPopulationDroides = new PopulationDroides();
            laPopulationDroides.Recherche(PremiereLettre);
            this.ViewBag.laPopulationDroides = laPopulationDroides;

            return View();
        }
    }
}
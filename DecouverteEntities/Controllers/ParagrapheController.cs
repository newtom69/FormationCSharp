using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DecouverteEntities.Models;

namespace DecouverteEntities.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {
            using (JeuDroidesFormationEntities context = new JeuDroidesFormationEntities())
            {
                var requete = from para in context.Paragraphe
                    orderby para.Numero
                    select para;

                return View(requete.ToList());
            }
            
        }


        public ActionResult Edit()
        {
            //using (JeuDroidesFormationEntities context = new JeuDroidesFormationEntities())
            //{
            //    var requete = from para in context.Paragraphe
            //        orderby para.Numero
            //        select para;

            //    return View(requete.ToList());
            //}

            return View();
        }
    }
}
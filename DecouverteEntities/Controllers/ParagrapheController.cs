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


        public ActionResult Edit(int id)
        {
            using (JeuDroidesFormationEntities context = new JeuDroidesFormationEntities())
            {
                var requete = from para in context.Paragraphe
                    where para.Id == id
                    orderby para.Numero
                    select para;

                Paragraphe leParagraphe = requete.SingleOrDefault(); // ou First();
                return View(leParagraphe);
            }
        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            return View();
        }

        public ActionResult Ajouter()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Ajouter(Paragraphe paragraphe)
        {
            using (JeuDroidesFormationEntities context = new JeuDroidesFormationEntities())
            {
                context.Paragraphe.Add(paragraphe);
                context.SaveChanges();
            }

            string ajoutOk = "Ajout paragraphe ok";
            ViewBag.ajoutOk = ajoutOk;
            return View(paragraphe);
        }
    }
}
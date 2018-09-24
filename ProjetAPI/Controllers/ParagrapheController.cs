using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MaSuperLibrairie.DataLayers;
using MaSuperLibrairie.Models;

namespace ProjetAPI.Controllers
{
    public class ParagrapheController : ApiController
    {
        public IEnumerable<Paragraphe> Get()
        {
            ParagrapheDataLayer monParagrapheDataLayer = new ParagrapheDataLayer();
            List<Paragraphe> listParagraphes = monParagrapheDataLayer.GetAll();

            return listParagraphes;
        }

    }

}

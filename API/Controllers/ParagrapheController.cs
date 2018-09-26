using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MaSuperLibrairie.DataLayers;
using MaSuperLibrairie.Models;

namespace API.Controllers
{
    public class ParagrapheController : ApiController
    {
         //GET api/Paragraphe
        public IEnumerable<Paragraphe> Get()
        {
            return new ParagrapheDataLayer().GetAll();
        }
         //GET api/Paragraphe/id
        public Paragraphe Get(int numero)
        {
            return new ParagrapheDataLayer().GetOne(numero);
        }
    }
}

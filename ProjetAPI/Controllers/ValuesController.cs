﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MaSuperLibrairie.DataLayers;
using MaSuperLibrairie.Models;

namespace ProjetAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Paragraphe> Get()
        {
            ParagrapheDataLayer monParagrapheDataLayer = new ParagrapheDataLayer();
            List<Paragraphe> listParagraphes = monParagrapheDataLayer.GetAll();

            return listParagraphes;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

﻿using System.Collections.Generic;
using System.Linq;
using MaSuperLibrairie.Models;
using Paragraphe = MaSuperLibrairie.Models.Paragraphe;

namespace MaSuperLibrairie.DataLayers
{
    public class ParagrapheDataLayer
    {
        public List<Paragraphe> GetAll()
        {
            using (MonSuperContext context = new MonSuperContext())
            {
                var requete = from para in context.Paragraphe
                              orderby para.Numero
                              select para;

                return requete.ToList();
            }

        }

        public Paragraphe GetOne(int numero)
        {
            using (MonSuperContext context = new MonSuperContext())
            {
                var requeteOne = from para in context.Paragraphe
                              where para.Numero == numero
                              select para;
                return requeteOne.Single();
            }

        }
    }
}
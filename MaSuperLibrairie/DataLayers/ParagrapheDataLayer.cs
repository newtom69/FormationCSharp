using System.Collections.Generic;
using System.Linq;
using MaSuperLibrairie.Models;

namespace MaSuperLibrairie.DataLayers
{
    public class ParagrapheDataLayer
    {
        public List<Paragraphe> GetAll()
        {
            using (JeuDroidesFormationEntities context = new JeuDroidesFormationEntities())
            {
                var requete = from para in context.Paragraphe
                              orderby para.Numero
                              select para;

                return requete.ToList();
            }

        }

        public Paragraphe GetOne(int numero)
        {
            using (JeuDroidesFormationEntities context = new JeuDroidesFormationEntities())
            {
                var requeteOne = from para in context.Paragraphe
                              where para.Numero == numero
                              select para;
                return requeteOne.Single();
            }

        }
    }
}
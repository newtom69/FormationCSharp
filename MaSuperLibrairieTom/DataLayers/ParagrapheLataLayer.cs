using System.Collections.Generic;
using System.Linq;
using MaSuperLibrairie.Models;

namespace MaSuperLibrairie.DataLayers
{
    public class ParagrapheLataLayer
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
    }
}
using MaSuperLibrairie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSuperLibrairie.DataLayers
{
    public class ParagrapheDataLayer
    {
        public List<Paragraphe> GetAll()
        {
            using (Models.MonSuperContext context = new MonSuperContext())
            {
                var query = from unevariablecommetuveux in context.Paragraphe
                            orderby unevariablecommetuveux.Numero
                            select unevariablecommetuveux;

                return query.ToList();

                //return context.Paragraph
                //              .OrderBy(item => item.Numero)
                //              .ToList();
            }
        }
    }
}

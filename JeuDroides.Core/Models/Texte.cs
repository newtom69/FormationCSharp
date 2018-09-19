using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JeuDroides.Core.Models
{
    public abstract class Texte
    {
        public string Contenu { get; set; }

        //préférer les converter au ToString
        public override String ToString()
        {
            return Contenu;
        }
    }
}
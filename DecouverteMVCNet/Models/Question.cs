using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DecouverteMVCNet.Models
{
    public class Question : Texte
    {
        //public int _id;
        public List<Reponse> LesReponses { get; set; }
        //public int _paragrapheId;


        public Question()
        {
            //_paragrapheId = leParagraphe._id;
            //_id = 7;
            Contenu = "la question";

        }
    }
}
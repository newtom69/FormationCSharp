using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteMVCNet.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET: Paragraphe
        public ActionResult Index()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.MaConnexion;
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        int questionPrecedente = 0;
                        command.CommandText =
                            " SELECT Paragraphe.Contenu as ContenuParagraphe," +
                            "  Question.Id as QuestionID," +
                            "  Question.Contenu as laQuestion," +
                            "  Reponse.Contenu as laReponse" +
                            " FROM Question" +
                            " JOIN Reponse on Question.Id = Reponse.QuestionId" +
                            " JOIN Paragraphe on Question.ParagrapheId = Paragraphe.Id" +
                            " WHERE Paragraphe.Id = " + "1" +
                            " ORDER by Reponse.Id";

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> ListeReponse = new List<string>();
                            string Paragraphe = "";
                            string Question = "";

                            while (reader.Read())
                            {
                                int questionCourante = (int)reader["QuestionID"];
                                if (questionCourante != questionPrecedente)
                                {
                                    Paragraphe = (string)reader["ContenuParagraphe"];
                                    Question = (string)reader["laQuestion"];
                                    questionPrecedente = questionCourante;
                                }
                                ListeReponse.Add( (string) reader["laReponse"] );
                            }
                            ViewBag.LeParagraphe = Paragraphe ;
                            ViewBag.LaQuestion = Question;
                            ViewBag.LaListeReponses = ListeReponse;
                        }
                    }
                }
            }
            catch
            {
                ViewBag.LeParagraphe = "erreur base de données";
                ViewBag.LaQuestion = "erreur base de données";
                ViewBag.LaListeReponses = "erreur base de données";
            }

         

            return View();
        }
    }
}
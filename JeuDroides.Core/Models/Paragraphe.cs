using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using JeuDroides.Core.Properties;

namespace JeuDroides.Core.Models
{
    public class Paragraphe : Texte
    {
        public int _id;
        public Question LaQuestion { get; set; }


        public void Initialiser()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Settings.Default.MaConnexion;
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
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
                        this.LaQuestion = new Question();
                        this.LaQuestion.LesReponses = new List<Reponse>();

                        while (reader.Read())
                        {
                            this.Contenu = reader["ContenuParagraphe"].ToString();
                            this.LaQuestion.Contenu = reader["laQuestion"].ToString();

                            Reponse laReponseEnCours = new Reponse();
                            laReponseEnCours.Contenu = reader["laReponse"].ToString();
                            this.LaQuestion.LesReponses.Add(laReponseEnCours);
                        }

                    }
                }

            }
        }

        public Paragraphe()
        {
            _id = 3;
        }
    }
}

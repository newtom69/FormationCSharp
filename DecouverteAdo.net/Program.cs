using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Console;
using System.Configuration;
using System.Linq.Expressions;

namespace DecouverteAdo.net
{
    class Program
    {
        static void Main()
        {
            string nomAuteur = ConfigurationManager.AppSettings["nom"];
            string prenomAuteur = ConfigurationManager.AppSettings["prenom"];
            WriteLine("Programme entièrement écrit par {0} {1} :D\n", prenomAuteur, nomAuteur);

            string nomAppplication = Properties.Settings.Default.NomApp;
            WriteLine(nomAppplication);

            // se connecter à la base de donnée
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {

                    ConnectionStringSettings connex = ConfigurationManager.ConnectionStrings["ServeurTestUser"];
                    connection.ConnectionString = connex.ConnectionString;

                    //string connectionsString = Properties.Settings.Default.Toto;

                    connection.Open();

                    WriteLine("Quel paragraphe ?");
                    string numParagraphe = ReadLine();
                    Int32 idParagraphe;
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = " SELECT Id" +
                                              " FROM Paragraphe" +
                                              " WHERE Numero=" + numParagraphe;
                        //commandBuilder

                        //entities = ORM

                        object retourExecScalar = command.ExecuteScalar();
                        if (retourExecScalar != null)
                        {
                            idParagraphe = (int) retourExecScalar;
                        }
                        else
                        {
                            WriteLine("numéro de paragraphe invalide => valeur par défaut choisie");
                            idParagraphe = 1;
                        }
                    }

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        int numReponse = 0;
                        int questionPrecedente = 0;
                        //WriteLine("combien d'espace svp ?");
                        //int nbespaces = Int32.Parse(ReadLine());
                        int nbespaces = 1;
                        string espaces = new String(' ', nbespaces);

                        command.CommandText =
                            " SELECT Paragraphe.Contenu as ContenuParagraphe," +
                            "  Question.Id as QuestionID," +
                            "  Question.Contenu as laQuestion," +
                            "  Reponse.Contenu as laReponse" +
                            " FROM Question" +
                            " JOIN Reponse on Question.Id = Reponse.QuestionId" +
                            " JOIN Paragraphe on Question.ParagrapheId = Paragraphe.Id" +
                            " WHERE Paragraphe.Id = " + idParagraphe +
                            " ORDER by Reponse.Id";

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int questionCourante = (int) reader["QuestionID"];
                                if (questionCourante != questionPrecedente)
                                {
                                    WriteLine(reader["ContenuParagraphe"]);
                                    WriteLine(reader["laQuestion"]);
                                    questionPrecedente = questionCourante;
                                    numReponse = 0;
                                }

                                Write(espaces + ++numReponse + " : " + reader["laReponse"]);
                            }
                        }
                    }

                    WriteLine("Quel matricule de droide dont le nom à changer ?");
                    String matriculeDroide = ReadLine();
                    WriteLine("Quel nom à mettre ?");
                    String nomDroide = ReadLine();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText =
                            " UPDATE Droide" +
                            " SET Nom = '" + nomDroide + "'" +
                            " ,   DateDerniereMAJ = GETDATE()" +
                            " WHERE Matricule = '" + matriculeDroide + "'";

                        int nbLigneAffect = command.ExecuteNonQuery();
                        WriteLine(nbLigneAffect + " affecté(s)");
                    }
                }
            }
            catch (SqlException e)
            {
                WriteLine("Erreur SQL");
                WriteLine(e.Message);
                
            }
            catch (Exception e)
            {
                WriteLine("Erreur non SQL");
                WriteLine(e.Message);
                //log for net
            }
            finally
            {
                ReadLine(); 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteAdoNetBisExecuteNonQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = 
                Properties.Settings.Default.AccesBaseDonneesDev;

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;


                    #region essai du try catch
                    try
                    {
                        decimal result = 0;
                        Console.WriteLine("Valeur a saisir");
                        string valeurSaisie = Console.ReadLine();
                        int valeurReelle = int.Parse(valeurSaisie);

                        Console.WriteLine("La valeur saisie est " + valeurReelle);
                    }
                    finally
                    {
                        Console.WriteLine("Je passe dans le finally");
                    }



                    Console.WriteLine("J'affiche un info après le bloc de try finally");
                    #endregion

                    connection.Open();

                    Console.WriteLine("Donnez un matricule ?");
                    string matricule = Console.ReadLine();

                    Console.WriteLine("Quel est l'id à modifier ?");
                    string idEnChaine = Console.ReadLine();

                    //int idReel = int.Parse(idEnChaine);

                    int maValeurEntiereHypothetique = 0;
                    if (int.TryParse(idEnChaine, out maValeurEntiereHypothetique))
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText =
                                "UPDATE [dbo].[Droide] " +
                                "SET[Matricule] = '" + matricule + "' " +
                                ",[DateDerniereMiseAJour] = getdate() " +
                                "WHERE Id = " + maValeurEntiereHypothetique;

                            int nbElements = command.ExecuteNonQuery();
                            if (nbElements > 0)
                                Console.WriteLine("Ca a bien fonctionné");
                        }
                    }
                }
            }
            
            catch (SqlException ex)
            {
                System.Console.WriteLine("La connection n'a pas pu etre établie.");
                Console.WriteLine("Ex : " + ex.Message + ", " + ex.StackTrace);

            }
            catch(FormatException ex)
            {

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Autre erreur attrapée");
            }

            Console.WriteLine("Je suis un alien");

            Console.ReadLine();
        }
    }
}

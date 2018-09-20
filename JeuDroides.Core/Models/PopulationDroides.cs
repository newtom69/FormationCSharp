using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuDroides.Core.Properties;

namespace JeuDroides.Core.Models
{
    public class PopulationDroides
    {
        public List<Droide> lesDroides { get; set; }


        public void Recherche(char premierCaractere)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Settings.Default.MaConnexion;
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = " SELECT Nom FROM Droide where Nom like '"+ premierCaractere + "%'";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        this.lesDroides = new List<Droide>();

                        while (reader.Read())
                        {
                            Droide leDroideEnCours = new Droide();
                            leDroideEnCours.nom = reader["nom"].ToString();
                            this.lesDroides.Add(leDroideEnCours);
                        }

                    }
                }

            }
        }
    }
}

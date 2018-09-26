using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppelAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                string monUrlDeLapi= "http://localhost/ProjetAPI/api/paragraphe";
                string monContenuVenantDuServeur = client.DownloadString(monUrlDeLapi);
                Console.WriteLine(monContenuVenantDuServeur);
                Console.ReadLine();
            }



        }
    }
}

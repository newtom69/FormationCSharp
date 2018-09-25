using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleAPI.Models;
using Newtonsoft.Json;

namespace ConsoleAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemple reflexion
            //ClassDeTestJSon test = new ClassDeTestJSon();

            //Type monType = test.GetType();

            //var mesProps = monType.GetProperties();
            //foreach (var prop in mesProps)
            //{
            //    Console.WriteLine(prop.Name);
            //}
            #endregion

            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                string monUrlDeLapi = "http://localhost/TestAPI/api/paragraphe";
                string monContenuVenantDuServeur = client.DownloadString(monUrlDeLapi);

                //[
                // { "Id":1,"Numero":42,"Contenu":"sdsdsds","Titre":null},
                // { "Id":2,"Numero":63,"Contenu":"oooo","Titre":null}
                //]
                List<ClassDeTestJSon> list =
                    JsonConvert.DeserializeObject<List<ClassDeTestJSon>>(monContenuVenantDuServeur);
                Console.WriteLine("Voilà les numéro des paragraphes");
                foreach (var item in list)
                {
                    Console.WriteLine(item.Numero);
                }
            }
            using (WebClient client2 = new WebClient())
            {

                Console.WriteLine("Quel numéro vous voulez ?");
                string numero = Console.ReadLine();


                string url2 = "http://localhost/TestAPI/api/paragraphe/"+ numero;
                string contenu2 = client2.DownloadString(url2);
                ClassDeTestJSon ContenuJSon = JsonConvert.DeserializeObject<ClassDeTestJSon>(contenu2);

                Console.WriteLine(ContenuJSon.Contenu);

                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


// CW tab tab pour console write

namespace JeuDroides.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string monHistoire = "Il était une fois dans une galaxie lointaine... très lointaine... ";
         
            string sexe = "0";
            bool saisie = false;
            while (sexe != "F" && sexe != "H")
            {
                if (saisie)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Vous n'avez pas rentré H ou F, réessayez");
                    System.Console.ResetColor();
                }
                System.Console.WriteLine("Rentrer sexe (F/H)");
                sexe = System.Console.ReadKey().KeyChar.ToString().ToUpper();
                System.Console.WriteLine("");
                saisie = true;
            }          
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Vous avez rentré : " + sexe);
            System.Console.ResetColor();
            string nomJedi = "";
            saisie = false;
            while (nomJedi.Length < 3)
            {
                if (saisie)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Vous n'avez pas rentré un nom assez grand, réessayez");
                    System.Console.ResetColor();
                }
                System.Console.WriteLine("Rentrer le nom (>3 caractères)");
                nomJedi = System.Console.ReadLine().ToUpper();
                System.Console.WriteLine("");
                saisie = true;
            }

            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Vous avez rentré : " + nomJedi + "\n");
            System.Console.ResetColor();

            monHistoire += $"{(sexe=="F"?"une":"un")} jeune jedi : {nomJedi}";


            // recup valeurs d'une énumération
            System.Console.WriteLine("avec foreach de string");
            foreach (string s in Enum.GetNames(typeof(TypeEspece)))
            {
                System.Console.WriteLine(s);
            }

            System.Console.WriteLine("avec tableau de string");
            string[] tableauEspeces = Enum.GetNames(typeof(TypeEspece));
            for (int i = 0; i < tableauEspeces.Length; i++)
            {
                System.Console.Write(" -" + tableauEspeces[i]);
            }

       

            string[] Espece = new string[4] {"Humain", "Wooki", "Yoda", "Droïde"};
                       
            string chaineChoixEspece = "Voici les espèces disponibles :\n";
            for (int i = 0; i < Espece.Length; i++)
                chaineChoixEspece+=$"{Espece[i]} ({i}) - ";
            



            chaineChoixEspece = chaineChoixEspece.Substring(0, chaineChoixEspece.Length - 3);
            
            int choixEspece = -1;
            saisie = false;
            bool saisienum = false;
            string saisieString;
            while (choixEspece<0 || choixEspece > Espece.Length-1)
            {
                if (saisie)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Vous n'avez pas rentré une espèce valide, réessayez");
                    System.Console.ResetColor();
                }
                System.Console.WriteLine(chaineChoixEspece);
                System.Console.WriteLine("\nChoisissez votre espèce");
                saisieString = System.Console.ReadLine();
                saisienum = int.TryParse(saisieString, out choixEspece);
                if (!saisienum) choixEspece = -1;
                saisie = true;
            }
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Vous avez rentré : " + Espece[choixEspece]);
            System.Console.ResetColor();

            monHistoire += " dont l'espèce est : " + Espece[choixEspece];
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("\n" + monHistoire);


            //2018-09-10
            Jedi leJedi = new Jedi(nomJedi, sexe);

            string intro = "Vous commencez votre aventure dans l’espace, à bord d’un vaisseau." +
                           "\nVotre vaisseau est destiné à arriver sur la planète Geonosis pour commencer les combats.";

            string question = "Vous, {prenom} êtes un jedi débutant, c’est votre première bataille. " +
                              "\nUn Storm troopers à côté de vous, vous voit et vous demande:" +
                              "\nCa va master {prenom}. Vous semblez inquiet ? !" +
                              "\nQuelle est votre réponse ? ";


            
            Quete quete1 = new Quete(leJedi, intro, question);
            quete1.AfficherIntro();
            quete1.AfficherQuestion();
            quete1.DemanderReponse();


            System.Console.ReadLine();
        }
    }
}

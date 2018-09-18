using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur
{
    class Program
    {
        static void Main(string[] args)
        {

            int somme1 = demanderSomme();
            System.Console.WriteLine("addition des 2 nombres : " + somme1);
            int somme2 = demanderSomme();
            System.Console.WriteLine("addition des 2 nombres : " + somme2);
            int multipl1 = demanderMultiplication();
            System.Console.WriteLine("Multiplication des 2 nombres : " + multipl1);
            int multipl2 = demanderMultiplication();
            System.Console.WriteLine("Multiplication des 2 nombres : " + multipl2);
            System.Console.ReadLine();
        }

            static int demanderSomme()
            {
                string saisieString = "";
                bool saisie = false;
                bool saisienum = false;
                int nb1 = int.MinValue;
                int nb2 = int.MinValue;

                while (nb1 == int.MinValue)
                {
                    if (saisie)
                    {
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Vous n'avez pas rentré un nombre valide, réessayez");
                        System.Console.ResetColor();
                    }
                    System.Console.WriteLine("\nChoisissez votre nombre 1 pour somme");
                    saisieString = System.Console.ReadLine();
                    saisienum = int.TryParse(saisieString, out nb1);
                    if (!saisienum) nb1 = int.MinValue;
                    saisie = true;
                }

                saisie = false;
                saisienum = false;
                while (nb2 == int.MinValue)
                {
                    if (saisie)
                    {
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Vous n'avez pas rentré un nombre valide, réessayez");
                        System.Console.ResetColor();
                    }
                    System.Console.WriteLine("\nChoisissez votre nombre 2 pour somme");
                    saisieString = System.Console.ReadLine();
                    saisienum = int.TryParse(saisieString, out nb2);
                    if (!saisienum) nb2 = int.MinValue;
                    saisie = true;
                }
                return Somme(nb1, nb2);
            }

        static int demanderMultiplication()
        {
            string saisieString = "";
            bool saisie = false;
            bool saisienum = false;
            int nb1 = int.MinValue;
            int nb2 = int.MinValue;

            while (nb1 == int.MinValue)
            {
                if (saisie)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Vous n'avez pas rentré un nombre valide, réessayez");
                    System.Console.ResetColor();
                }
                System.Console.WriteLine("\nChoisissez votre nombre 1 pour multiplication");
                saisieString = System.Console.ReadLine();
                saisienum = int.TryParse(saisieString, out nb1);
                if (!saisienum) nb1 = int.MinValue;
                saisie = true;
            }

            saisie = false;
            saisienum = false;
            while (nb2 == int.MinValue)
            {
                if (saisie)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Vous n'avez pas rentré un nombre valide, réessayez");
                    System.Console.ResetColor();
                }
                System.Console.WriteLine("\nChoisissez votre nombre 2 pour la multiplication");
                saisieString = System.Console.ReadLine();
                saisienum = int.TryParse(saisieString, out nb2);
                if (!saisienum) nb2 = int.MinValue;
                saisie = true;
            }
            return Multiplie(nb1, nb2);
        }
            
        

        static int Somme(int a, int b)
        {
            return a + b;
        }

        static int Multiplie(int a, int b)
        {
            return a * b;
        }
    }
} 

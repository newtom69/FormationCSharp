using System;

namespace ZooDesRobots
{
    class Program
    {
        static void Main()
        {

            Animal animal1 = new Elephant(250.5M, "Dumbo", 4, true);
            Animal animal2 = new Humain(100, "Juste Leblanc", 4, true);
            Animal animal3 = new Oiseau("zouzouille", 2);

            Console.Write(animal1.GetName() + " ");
            Console.WriteLine(animal1.EcritAttributs());
            Console.WriteLine("il dort " + animal1.GetFaconDeDormir());
            Console.WriteLine();

            Console.Write(animal2.GetName() + " ");
            Console.WriteLine(animal2.EcritAttributs());
            Console.WriteLine("il dort " + animal2.GetFaconDeDormir());
            Console.WriteLine();

            Console.Write(animal3.GetName() + " ");
            Console.WriteLine(animal3.EcritAttributs());
            Console.WriteLine("il dort " + animal3.GetFaconDeDormir());
            Console.WriteLine();

            Console.WriteLine(animal3.ToString() + "\n");

            if (animal1.GetEnTrainDeDormir())
                Console.WriteLine(animal1.GetName() + " dort actuellement");
            else
                Console.WriteLine(animal1.GetName() + " ne dort pas actuellement");

            Console.WriteLine("on va faire dormir " + animal1.GetName());
            Console.ReadLine();
            animal1.Dort();

            if (animal1.GetEnTrainDeDormir())
                Console.WriteLine(animal1.GetName() + " dort actuellement");
            else
                Console.WriteLine(animal1.GetName() + " ne dort pas actuellement");

            animal1.GetEnTrainDeDormir();

            //test correspondance int des enum
            //string[] tableauEspeces = Enum.GetNames(typeof(TypeEspece));
            //for (int i = 0; i < tableauEspeces.Length; i++)
            //{
            //    string especeCourante = tableauEspeces[i];
            //    TypeEspece monType = (TypeEspece)Enum.Parse(typeof(TypeEspece), especeCourante);
            //    int maValeurEspece = (int)monType;
            //    System.Console.Write(" id: " + maValeurEspece + "  " + especeCourante);
            //}


            string nourriture1;
            string nourriture2;
            Console.WriteLine("entrer nourriture animal 1");
            nourriture1 = Console.ReadLine();
            animal1.DonnerAManger(nourriture1);
            Console.WriteLine("entrer nourriture animal 2");
            nourriture2 = Console.ReadLine();
            animal2.DonnerAManger(nourriture2);
            

            DateTime dateDernierRepas1 = animal1.GetDateDernierRepas();
            DateTime dateDernierRepas2 = animal2.GetDateDernierRepas();

            Console.WriteLine(animal1.GetDernierRepas() + " donné à : " + animal1.GetName() + " le " + dateDernierRepas1);
            Console.WriteLine(animal2.GetDernierRepas() + " donné à : " + animal2.GetName() + " le " + dateDernierRepas2);

            

            Console.ReadLine();
        }

    }
}

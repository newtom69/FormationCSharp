using System;

namespace ZooDesRobots
{
    public class Animal
    {
        public TypeFaconDeDormir FaconDeDormir;
        private bool _enTrainDeDormir;
        private readonly string _nom;
        readonly int _nbMembres;
        bool AuneBouche;
        DateTime _dateDernierRepas;
        string _dernierRepas = "";

        public Animal(string nom, int nbMembres, bool auneBouche)
        {
            _nom = nom;
            _nbMembres = nbMembres;
            AuneBouche = auneBouche;
            _enTrainDeDormir = false;
        }

        public TypeFaconDeDormir GetFaconDeDormir()
        {
            return FaconDeDormir;
        }

        public void EcritCommeTuDors()
        {
            Console.WriteLine("je dors " + FaconDeDormir);
        }

        public bool GetEnTrainDeDormir()
        {
            return _enTrainDeDormir;
        }

        public void Dort()
        {
            _enTrainDeDormir = true;

        }
        
        public string GetName()
        {
            return _nom;
        }

        public int GetNbMembres()
        {
            return _nbMembres;
        }
        public bool GetAuneBouche()
        {
            return AuneBouche;
        }
        public string EcritAttributs()
        {
            return (GetAuneBouche() ? "a une bouche" : "n'a pas de bouche") + " et " + GetNbMembres() + " membre" + (GetNbMembres() > 1 ? "s" : "");
        }
        public void DonnerAManger(string nourriture)
        {
            _dateDernierRepas = DateTime.Now;
            _dernierRepas = nourriture;
        }
        public DateTime GetDateDernierRepas()
        {
            return _dateDernierRepas;
        }
        public string GetDernierRepas()
        {
            return _dernierRepas;
        }

    }
}

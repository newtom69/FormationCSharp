namespace JeuDroides.Console.UI
{
    public class Jedi
    {
        private Joueur _joueur;

        private readonly string _nom;

        private string _sexe;
        //readonly int _nbMembres;
        //DateTime _dateDernierRepas;
        //string _dernierRepas = "";

        public Jedi(string nom)
        {
            _nom = nom;
            _sexe = "H";
        }

        public Jedi(string nom, string sexe)
        {
            _nom = nom;
            _sexe = sexe;
        }

        public string GetName()
        {
            return _nom;
        }

  
  
    }
}

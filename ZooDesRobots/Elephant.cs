namespace ZooDesRobots
{
    public class Elephant : Animal
    {
        private decimal _longueurTrompe=100.50M;


        public Elephant(decimal longueurTrompe, string nom, int nbMembres, bool auneBouche) : base(nom, nbMembres, auneBouche)
        {
            _longueurTrompe = longueurTrompe;
            FaconDeDormir = TypeFaconDeDormir.Debout;
        }
    }
}

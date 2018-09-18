namespace ZooDesRobots
{
    public class Humain : Animal
    {
        private decimal _qi = 75;


        public Humain(decimal qi, string nom, int nbMembres, bool auneBouche) : base(nom, nbMembres, auneBouche)
        {
            _qi = qi;
            FaconDeDormir = TypeFaconDeDormir.Allonge;
        }
    }
}

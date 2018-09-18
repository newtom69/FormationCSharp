namespace ZooDesRobots
{
    public class Oiseau : Animal
    {
        public Oiseau(string nom, int nbMembres) : base(nom, nbMembres, false)
        {
            FaconDeDormir = TypeFaconDeDormir.Assis;
        }
    }
}

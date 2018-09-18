namespace JeuDroides.Console.UI
{
    class Quete
    {
        private Jedi _jedi;
        private string _intro;
        private string _question;
        private list _choix;
        private string _reponse;

        public Quete(Jedi jedi, string intro, string question)
        {
            _jedi = jedi;
            _intro = intro;
            _question = question;
        }

        public void AfficherIntro()
        {
            System.Console.Write(_intro);
        }

        public void AfficherQuestion()
        {
            System.Console.WriteLine(_question);
        }

        public void DemanderReponse()
        {
            _reponse = System.Console.ReadLine();
            //TODO
            //stocker reponse
        }

    }
}

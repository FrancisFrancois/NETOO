namespace JeuxBattle.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Mage mage1 = new Mage("Gandalf", 100, 10);
            Guerrier guerrier1 = new Guerrier("Legolas", 100, 15);
            Chasseur chasseur1 = new Chasseur("Aragorn", 100, 20);

            mage1.LancerAttaque(guerrier1);
            mage1.SeSoigner();

            guerrier1.Attaquer(mage1);
            guerrier1.Resiste(mage1);

            chasseur1.Attaquer(guerrier1);
            chasseur1.LancerAttaque(mage1);

       
            Console.WriteLine($"{mage1.Nom} a {mage1.PV} PV.");
            Console.WriteLine($"{guerrier1.Nom} a {guerrier1.PV} PV.");
            Console.WriteLine($"{chasseur1.Nom} a {chasseur1.PV} PV.");

            Console.ReadLine();
        }
    }
}

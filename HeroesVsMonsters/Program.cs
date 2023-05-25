using HeroesVsMonsters.Heroes;
using HeroesVsMonsters.Monstres;

namespace HeroesVsMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hero humain = new Humain("Jean");
            Hero nain = new Nain("Nahleubeuk");

            Monstre loup = new Loup("Loup");
            Monstre dragonnet = new Dragonnet("Drako");


            Console.WriteLine("Points de vie avant la frappe :");
            Console.WriteLine($"{humain.Nom} : {humain.PV}");
            Console.WriteLine($"{loup.Nom} : {loup.PV}");
            Console.WriteLine();

            humain.FrappeEnnemi(loup);
            nain.FrappeEnnemi(dragonnet);

            Console.WriteLine("Points de vie après la frappe :");
            Console.WriteLine($"{humain.Nom} : {humain.PV}");
            Console.WriteLine($"{loup.Nom} : {loup.PV}");
            Console.WriteLine();

            humain.RecupererRichesse(loup);

      
            Console.WriteLine("Or du héros : " + humain.Or);
            Console.WriteLine("Cuir du héros : " + humain.Cuir);

         

        }
    }
}
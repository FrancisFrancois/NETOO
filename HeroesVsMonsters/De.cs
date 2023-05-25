using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class De
    {
        private static Random random = new Random();

        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public De(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public static int Lancer(int minimum, int maximum)
        {
            return random.Next(minimum, maximum + 1);
        }

        public static int GenererForceEtEndurance()
        {
            List<int> des = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                des.Add(Lancer(1, 6));
            }

            des.Sort();
            des.Reverse();

            int somme = des.Take(3).Sum();

            return somme;
        }

        public static int GenererFrappe()
        {
            return Lancer(1, 4);
        }

        public static int GenererOr()
        {
            return Lancer(1, 6);
        }

        public static int GenererCuir()
        {
            return Lancer(1, 4);
        }


    }
}
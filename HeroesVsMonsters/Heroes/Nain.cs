using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Heroes
{
    public class Nain : Hero
    {
        public Nain(string nom) : base(nom)
        {
            AppliquerBonus(2, 0);
        }
    }
}

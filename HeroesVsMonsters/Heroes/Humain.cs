using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Heroes
{
    public class Humain : Hero
    {
        public Humain(string nom) : base(nom)
        {
            AppliquerBonus(1, 1);
        }
    }
}

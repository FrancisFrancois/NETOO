using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Monstres
{
    public class Orque : Monstre, IOr
    {
        public Orque(string nom) : base(nom)
        {
            AppliquerBonus(0, 1);
        }
        public int RecupererOr()
        {
            int or = De.GenererOr();
            return or;
        }
    }
}

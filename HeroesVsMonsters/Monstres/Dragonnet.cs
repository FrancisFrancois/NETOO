using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Monstres
{
    public class Dragonnet : Monstre, ICuir, IOr
    {
        public Dragonnet(string nom) : base(nom)
        {
            AppliquerBonus(1, 0);
        }
        public int RecupererCuir()
        {
            int cuir = De.GenererCuir();
            return cuir;
        }

        public int RecupererOr()
        {
            int or = De.GenererOr();
            return or;
        }
    }
}

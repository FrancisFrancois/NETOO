using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Monstres;

namespace HeroesVsMonsters.Monstres
{
    public class Loup : Monstre, ICuir
    {
        public Loup(string nom) : base(nom)
        {

        }
        public int RecupererCuir()
        {
            int cuir = De.GenererCuir();
            return cuir;
        }
    }

}


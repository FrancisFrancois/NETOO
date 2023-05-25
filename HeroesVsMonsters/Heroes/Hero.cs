using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Monstres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Heroes
{
    public class Hero : Personnage, ICuir, IOr
    {
        public int Or { get; private set; }

        public int Cuir { get; private set; }

        public Hero(string nom) : base(nom)
        {
            
        }
        public void RecupererRichesse(Monstre monstre)
        {
            if (monstre is IOr)
            {
                 Or += ((IOr)monstre).RecupererOr();
            }

            if (monstre is ICuir)
            {
                Cuir += ((ICuir)monstre).RecupererCuir();
            }

        }
        public int RecupererOr()
        {
            int quantiteOr = Or;
            Or = 0;
            return quantiteOr;
        }

        public int RecupererCuir()
        {
            int quantiteCuir = Cuir;
            Cuir = 0;
            return quantiteCuir;
        }
    }
}




using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Monstres
{
    public class Monstre : Personnage
    {
        public int Or { get; set; }
        public int Cuir { get; set; }
        public Monstre(string nom) : base(nom)
        {
          
        }
    }
    }


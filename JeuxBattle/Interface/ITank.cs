using JeuxBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxBattle.Interface
{
    internal interface ITank
    {
        // Méthode pour résister à l'attaque d'un ennemi
        public void Resiste(Personnage ennemi);
    }
}

using JeuxBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxBattle.Interface
{
    internal interface IDistant
    {
        // Méthode pour lancer une attaque à distance sur un ennemi
        public void LancerAttaque(Personnage ennemi);
    }
}

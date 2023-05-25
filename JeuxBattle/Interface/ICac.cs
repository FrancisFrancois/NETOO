using JeuxBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxBattle.Interface
{
    public interface ICac
    {
        // Méthode pour effectuer une attaque au corps à corps sur un ennemi
        public void Attaquer(Personnage ennemi);
    }
}

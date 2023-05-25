using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxBattle.Models
{
    public abstract class Personnage
    {
        public string Nom { get; set; } // Propriété pour le nom du personnage
        public int PV { get; set; } // Propriété pour les points de vie du personnage
        public int Attaque { get; set; } // Propriété pour la valeur d'attaque du personnage

        public Personnage(string nom, int pv, int attaque)
        {
            Nom = nom; // Initialise le nom du personnage avec la valeur passée en paramètre
            PV = pv; // Initialise les points de vie du personnage avec la valeur passée en paramètre
            Attaque = attaque; // Initialise la valeur d'attaque du personnage avec la valeur passée en paramètre
        }
    }

}

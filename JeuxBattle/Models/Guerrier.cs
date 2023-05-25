using System;
using JeuxBattle.Interface;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxBattle.Models
{
    public class Guerrier : Personnage, ICac, ITank
    {
        // Constructeur de la classe Guerrier qui initialise les propriétés héritées du personnage
        public Guerrier(string nom, int pv, int attaque) : base(nom, pv, attaque)
        {
        }

        // Méthode d'attaque en corps à corps
        public void Attaquer(Personnage ennemi)
        {
            int degats = Attaque; // Calcul des dégâts basés sur la valeur de l'attaque du Guerrier
            ennemi.PV -= degats; // Réduction des PV de l'ennemi en fonction des dégâts infligés

            // Vérification et correction des PV pour éviter les valeurs négatives
            if (ennemi.PV < 0)
            {
                ennemi.PV = 0;
            }

            Console.WriteLine($"{Nom} a infligé {degats} points de dégâts à {ennemi.Nom}, qui a maintenant {ennemi.PV} PV.");

            // Vérification si l'ennemi a été tué
            if (ennemi.PV == 0)
            {
                Console.WriteLine($"{Nom} a tué {ennemi.Nom}.");
            }
        }

        // Méthode de résistance pour diminuer l'attaque de l'ennemi
        public void Resiste(Personnage ennemi)
        {
            ennemi.Attaque -= (int)(ennemi.Attaque * 0.05); // Réduction de l'attaque de l'ennemi de 5%

            Console.WriteLine($"{Nom} a réduit l'attaque de {ennemi.Nom} de 5%.");
        }
    }

}
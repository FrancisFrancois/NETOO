using JeuxBattle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxBattle.Models
{
    public class Chasseur : Personnage, ICac, IDistant
    {
        // Constructeur de la classe Chasseur qui initialise les propriétés héritées du personnage
        public Chasseur(string nom, int pv, int attaque) : base(nom, pv, attaque)
        {
        }

        // Méthode d'attaque en corps à corps
        public void Attaquer(Personnage ennemi)
        {
            int degats = Attaque; // Calcul des dégâts basés sur l'attaque du Chasseur
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

        // Méthode pour lancer une attaque à distance
        public void LancerAttaque(Personnage ennemy)
        {
            Random random = new Random();
            int chance = random.Next(1, 21); 

            // Vérification si l'attaque réussit ou échoue en fonction de la chance générée
            if (chance == 1) 
            {
                Console.WriteLine($"{Nom} a raté son attaque contre {ennemy.Nom}.");
            }
            else
            {
                int degats = Attaque; // Calcul des dégâts basés sur l'attaque du Chasseur
                ennemy.PV -= degats; // Réduction des PV de l'ennemi en fonction des dégâts infligés

                // Vérification et correction des PV pour éviter les valeurs négatives
                if (ennemy.PV < 0)
                {
                    ennemy.PV = 0;
                }

                Console.WriteLine($"{Nom} a infligé {degats} points de dégâts à {ennemy.Nom}, qui a maintenant {ennemy.PV} PV.");

                // Vérification si l'ennemi a été tué
                if (ennemy.PV <= 0)
                {
                    Console.WriteLine($"{Nom} a tué {ennemy.Nom}.");
                }
            }
        }
    }


}

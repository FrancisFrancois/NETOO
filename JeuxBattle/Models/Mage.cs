using JeuxBattle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxBattle.Models
{
    public class Mage : Personnage, ISoin, IDistant
    {
        // Constructeur de la classe Mage qui initialise les propriétés héritées du personnage
        public Mage(string nom, int pv, int attaque) : base(nom, pv, attaque)
        {
        }

        // Méthode de soin pour régénérer les points de vie du Mage
        public void SeSoigner(Personnage? personnage = null)
        {
            int soin = (int)(PV * 0.05); // Calcul du montant de soin basé sur 5% des points de vie actuels
            PV += soin; // Ajout des points de soin aux points de vie du Mage

            Console.WriteLine($"{Nom} s'est régénéré de {soin} PV.");
        }

        // Méthode de lancement d'attaque à distance
        public void LancerAttaque(Personnage ennemi)
        {
            Random random = new Random();
            int chance = random.Next(1, 21);

            if (chance == 1)
            {
                Console.WriteLine($"{Nom} a raté son attaque contre {ennemi.Nom}.");
            }
            else
            {
                int degats = Attaque; // Calcul des dégâts basés sur la valeur de l'attaque du Mage
                ennemi.PV -= degats; // Réduction des PV de l'ennemi en fonction des dégâts infligés

                Console.WriteLine($"{Nom} a infligé {degats} points de dégâts à {ennemi.Nom}, qui a maintenant {ennemi.PV} PV.");

                if (ennemi.PV <= 0)
                {
                    Console.WriteLine($"{Nom} a tué {ennemi.Nom}.");
                }
            }
        }
    }
}
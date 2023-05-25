using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Personnage
    {
 
        public string Nom { get; set; }
        public int Endurance { get; private set; }
        public int Force { get; private set; }
        public int PV { get; set; }
        public int Frappe { get; set; }

        public Personnage(string nom)
        {
          
            Nom = nom;
            Endurance = De.GenererForceEtEndurance();
            Force = De.GenererForceEtEndurance();
            PV = Modificateur.CalculerPV(Endurance); 
            Frappe = Modificateur.CalculerFrappe(Force);
        }

        public void AppliquerBonus(int bonusEndurance, int bonusForce)
        {
            Endurance = Endurance + bonusEndurance;
            Force = Force + bonusForce;
        }

        public void FrappeEnnemi(Personnage cible)
        {
            int degats = De.GenererFrappe() + Modificateur.CalculerModificateur(Force);
            cible.RetirerPointsDeVie(degats);
        }

        private void RetirerPointsDeVie(int degats)
        {
            PV -= degats;
         
        }
    }
}


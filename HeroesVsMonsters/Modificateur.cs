using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    public class Modificateur
    {
        public static int CalculerModificateur(int valeur)
        {
            int modificateur = 0;

            switch (valeur)
            {
                case int n when (n < 5):
                    modificateur = -1;
                    break;
                case int n when (n < 10):
                    modificateur = 0;
                    break;
                case int n when (n < 15):
                    modificateur = 1;
                    break;
                default:
                    modificateur = 2;
                    break;
            }

            return modificateur;
        }

        public static int CalculerPV(int endurance)
        {
            int modificateur = CalculerModificateur(endurance);
            int pv = endurance + modificateur;
            return pv;
        }

        public static int CalculerFrappe(int force)
        {
            int modificateur = CalculerModificateur(force);
            int frappe = force + modificateur;
            return frappe;
        }

    }
}

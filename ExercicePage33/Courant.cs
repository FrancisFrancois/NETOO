using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePage33
{
    class Courant
    {
        // Déclaration de la propriété "Numero" représentant le numéro du compte courant
        public string Numero { get; set; }

        // Déclaration de la propriété "Solde" représentant le solde du compte courant
        public double Solde { get; private set; } = 100;

        // Déclaration de la propriété "LigneDeCredit" représentant la limite de crédit autorisée
        public double LigneDeCredit { get; set; } = 200;

        // Déclaration de la propriété "Titulaire" représentant le titulaire du compte courant
        public Personne Titulaire { get; set; }

        // Méthode pour effectuer un retrait sur le compte courant
        public void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant demandé est supérieur au solde disponible.");
                return;
            }
            if (Solde - montant < LigneDeCredit)
            {
                Console.WriteLine("Montant trop élevé");
                return;
            }

            Solde -= montant;
            Console.WriteLine($"Le solde de votre compte est de {Solde}.");
        }

        // Méthode pour effectuer un dépôt sur le compte courant
        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Vous ne pouvez pas ajouter un montant inférieur à 0");
                return;
            }
            else
            {
                Solde += montant;
                Console.WriteLine($"Le solde de votre compte est de {Solde}.");
            }
        }

        // Surcharge de l'opérateur "+" pour l'addition de deux objets "Courant"
        public static double operator +(Courant c1, Courant c2)
        {
            // Retourne la somme des soldes si les soldes sont supérieurs à zéro, sinon retourne zéro
            return c1.Solde > 0 ? c1.Solde : 0 + c2.Solde > 0 ? c2.Solde : 0;
        }

        // Surcharge de l'opérateur "+" pour l'addition d'un double et d'un objet "Courant"
        public static double operator +(double valeur, Courant c1)
        {
            // Retourne la somme de la valeur et du solde si le solde est supérieur à zéro, sinon retourne zéro
            return valeur + c1.Solde > 0 ? c1.Solde : 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePage33
{
    internal class Banque
    {
        // Déclaration de la propriété "Nom" représentant le nom de la banque
        public string Nom { get; set; }

        // Déclaration d'un dictionnaire pour stocker les comptes courants, avec le numéro de compte comme clé
        Dictionary<string, Courant> Comptes { get; set; } = new Dictionary<string, Courant>();

        // Indexeur permettant d'accéder à un compte courant à partir de son numéro de compte
        public Courant this[string numeroCompte]
        {
            get
            {
                Courant c;
                Comptes.TryGetValue(numeroCompte, out c);
                return c;
            }
        }

        // Méthode pour ajouter un compte courant à la banque
        public void Ajouter(Courant courant)
        {
            if (!Comptes.ContainsKey(courant.Numero))
            {
                Comptes.Add(courant.Numero, courant);
                Console.WriteLine($"Compte {courant.Numero} bien ajouté");
            }
        }

        // Méthode pour supprimer un compte courant de la banque
        public void Supprimer(string numeroCompte)
        {
            if (Comptes.ContainsKey(numeroCompte))
            {
                Console.WriteLine($"Compte {this[numeroCompte].Numero} bien supprimé");
                Comptes.Remove(numeroCompte);
            }
        }

        // Méthode pour calculer le total des soldes des comptes courants appartenant à une personne donnée
        public double AvoirDesComptes(Personne titulaire)
        {
            double soldes = 0;

            // Création d'une liste de comptes courants à partir des valeurs du dictionnaire
            List<Courant> comptes = Comptes.Values.ToList();

            foreach (Courant courant in comptes)
            {
                // Vérification si le titulaire du compte correspond à la personne donnée
                if (courant.Titulaire == titulaire)
                {
                    // Utilisation de la surcharge d'opérateur "+" pour additionner les soldes des comptes
                    soldes += courant;
                }
            }

            return soldes;
        }
    }
}
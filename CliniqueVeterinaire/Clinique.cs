using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire
{
    internal class Clinique
    {
    
        Dictionary<string, Animal> ListeAnimaux { get; set; } = new Dictionary<string, Animal>();


        public Animal this[string nomAnimal]
        {
            get
            {
                Animal a;
                ListeAnimaux.TryGetValue(nomAnimal, out a);
                return a;
            }
        }

        public void Ajouter(Animal animal)
        {
            if (!ListeAnimaux.ContainsKey(animal.Nom))
            {
                ListeAnimaux.Add(animal.Nom, animal);
                Console.WriteLine($"Le nom de l'animal {animal.Nom} à bien été ajouté");
            }
        }

        public void Supprimer(string nomAnimal)
        {
            if (ListeAnimaux.ContainsKey(nomAnimal))
            {
                Console.WriteLine($"Le nom de l'animal {this[nomAnimal].Nom} à bien été supprimé");
                ListeAnimaux.Remove(nomAnimal);
            }
        }
    }
}

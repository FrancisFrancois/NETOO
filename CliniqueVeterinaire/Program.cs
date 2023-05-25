using CliniqueVeterinaire;

namespace CliniqueVeterinaire
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Clinique clinique = new Clinique();

            Chien c = new Chien();
            c.Nom = "Junior";
            c.Age = 3;
            c.Sexe = "Male";
            c.Pedigree = "Berger Allemand";

            List<Animal> Animals = new List<Animal>();

            clinique.Ajouter(c);
            clinique.Supprimer("Junior");

            string description = c.ToString();
            Console.WriteLine(description);


        }
    }
}
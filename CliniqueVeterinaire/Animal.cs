using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueVeterinaire
{
    internal class Animal
    {
        public string Sexe { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"Je m'appelle {Nom} et j'ai {Age} ans";
        }
    }
}

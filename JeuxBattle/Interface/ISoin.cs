using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuxBattle.Models;

namespace JeuxBattle.Interface
{
    public interface ISoin 
    {
        // Méthode pour se soigner
        public void SeSoigner(Personnage? personnage = null);
    }
}

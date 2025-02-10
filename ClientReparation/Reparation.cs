using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    public class Reparation
    {
        ///Classe qui permet de définir la ou les compétences necessaires pour réparer une voiture
        public List<Competences> competencesNecessaires = new List<Competences>();
        public Reparation(){}
        public Reparation(List<Competences> competencesNecessaires)
        {
            this.competencesNecessaires = competencesNecessaires;
        }
    }
}

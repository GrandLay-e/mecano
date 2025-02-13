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
        private List<Competences> competencesNecessaires = new List<Competences>();

        public List<Competences> CompetencesNecessaires
        {
            get { return competencesNecessaires;}
            set { competencesNecessaires = value;}
        }
        public Reparation(){}
        public Reparation(List<Competences> competencesNecessaires)
        {
            this.competencesNecessaires = competencesNecessaires;
        }
    }
}

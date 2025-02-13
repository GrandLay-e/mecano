using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    public class Competences
    {
        ///La classe compétence qu'aura un mécanicien en multiple dans une collection
        private string competence;

        public string Competence
        {
            get { return competence; }
            set { competence = value; }
        }
        public Competences() {}
        public Competences(string competence)
        {
            this.competence = competence;
        }
    }
}

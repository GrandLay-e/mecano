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
        public string competence;
        public Competences() {}
        public Competences(string competence)
        {
            this.competence = competence;
        }
    }
}

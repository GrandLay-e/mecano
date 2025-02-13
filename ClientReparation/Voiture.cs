using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    public class Voiture
    {
        private string marque;
        private string matricule;
        private bool enPanne;
        private string panne;

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public bool EnPanne
        {
            get { return enPanne; }
            set { enPanne = value; }
        }

        public string Panne
        {
            get { return panne; }
            set { panne = value; }
        }

        ///Constructeur par défaut
        public Voiture()
        {
            this.Marque = "";
            this.Matricule = "";
            this.EnPanne = false;
            this.Panne = "";
        }

        ///Constructeur principal
        public Voiture(string marque, string matricule, bool enPanne, string panne = "")
        {
            this.Marque = marque;
            this.Matricule = matricule;
            this.EnPanne = enPanne;
            if (this.EnPanne)
            {
                this.AjouterPanne(panne);
            }
            else
            {
                this.Panne = "";
            }
        }

        ///A appeler quand une voiture tombe en panne, ce qui convertit automatiquement 
        ///la boolenne ePanne à true, et ce uniquement si la panne est "valide" pas de chaine vide
        public void AjouterPanne(string panne)
        {
            if (panne.Length > 1)
            {
                this.Panne = panne;
                this.EnPanne = true;
            }
        }

        public bool Rouler()
        {
            if (this.EnPanne)
            {
                return false;
            }
            return true;
        }

        ///Afficher les infroamtions d'une voiture
        public string AfficherVoiture()
        {
            string details = $"Marque : {this.Marque}\n" +
                $"\tMatricule : {this.Matricule}\n\tEtat : ";
            if (this.EnPanne)
            {
                details += $"\tEn panne de {this.Panne}\n";
            }
            else
            {
                details += "\tEn bon état\n";
            }
            return details;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    public class Voiture 
    {
        public string marque;
        public string matricule;
        public bool enPanne;
        public string panne;

        ///Constructeur par défaut
        public Voiture()
        {
            this.marque = "";
            this.matricule = "";
            this.enPanne = false;
            this.panne = "";
        }
        ///Constructeur principal
        public Voiture(string marque, string matricule, bool enPanne, string panne = "")
        {
            this.marque = marque;
            this.matricule = matricule;
            this.enPanne = enPanne;
            if (this.enPanne){
                this.AjouterPanne(panne);
            }else{
                this.panne = "";
            }
        }
        ///A appeler quand une voiture tombe en panne, ce qui convertit automatiquement 
        ///la boolenne ePanne à true, et ce uniquement si la panne est "valide" pas de chaine vide
        public void AjouterPanne(string panne)
        {
            if (panne.Length > 1)
            {
                this.panne = panne;
                this.enPanne = true;
            }
        }
        public bool Rouler()
        {
            if (this.enPanne)
            {
                return false;
            }
            return true;
        }

        ///Afficher les infroamtions d'une voiture
        public string AfficherVoiture()
        {
            string details = $"Marque : {this.marque}\n" +
                $"\tMatricule : {this.matricule}\n\tEtat : ";
            if (this.enPanne){
                details += $"\tEn panne de {this.panne}\n";
            }else{
                details += "\tEn bon état\n";
            }return details;
        }
    }
}

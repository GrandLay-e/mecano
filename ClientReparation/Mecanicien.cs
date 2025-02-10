using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    public class Mecanicien:Personne
    {
        ///Un mecanicien a des compétences
        public  List<Competences> _competences = new List<Competences>();

        ///Constructeur pas defaut
        public Mecanicien()
        {
            this._competences = new List<Competences>();
        }

        ///Constructeur principal
        public Mecanicien(string nom, 
                          string prenom, 
                          string adresse, 
                          List<Competences> competences) : base(nom, prenom, adresse)
        {
            this._competences = competences;
        }

        ///Methode pour ajouter une compétence pour le mecanicien
        private void AjouterCompetence(Competences _competence)
        {
            ///Ajouter si la compétences n'est pas encore sur les siens
            if (!this.EstCompetentPour(_competence) && _competence.competence != "")
            {
                this._competences.Add(_competence);
            }
        }

        ///Le mecanicien peut apprendre de nouvelles compétences, on fait appel ici à la methode AjouterCompetences()
        public void ApprendreNouvelleCompetence(Competences _competence) => this.AjouterCompetence(_competence);

        ///Une booleenne pour vérifier si le mecanicien et compétent pour réparer une panne
        public bool EstCompetentPour(Competences _competence)
        {
            string compet = _competence.competence;
            for (int i = 0; i < this._competences.Count; i++)
            {
                if (this._competences[i].competence == compet)
                {
                    return true;
                }
            }
            return false;
        }

        ///Il répare la voiture, une methode appelée uniquement si la précedente est vraie
        public void Reparer(Voiture voiture)
        {
            voiture.enPanne = false;
            voiture.panne = "";
        }

        ///Stocker les informations du mécanicien dans une methode qui sera concaténée à la methode
        ///virtuelle d'affichage de la classe Personne
        private string InformationsMecano()
        {
            string infos = $"Compétences : ";
            if(this._competences.Count > 0)
            {
                for(int i = 0;i < this._competences.Count; i++)
                {
                    infos +=$"\n\t{i+1} - {this._competences[i].competence}";
                }
            }else{
                infos += "Zéro";
            }
            return infos + "\n";
        }

        ///Donne les informations complètes du mécanicien
        public override string AfficherInfos()
        {
            return base.AfficherInfos() + this.InformationsMecano();
        }
    }
}

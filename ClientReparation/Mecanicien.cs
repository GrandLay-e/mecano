using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    public class Mecanicien : Personne
    {
        ///Un mecanicien a des compétences
        private List<Competences> competences = new List<Competences>();

        ///Constructeur pas defaut
        public Mecanicien()
        {
            this.Competences = new List<Competences>();
        }

        ///Constructeur principal
        public Mecanicien(string nom,
                          string prenom,
                          string adresse,
                          List<Competences> competences) : base(nom, prenom, adresse)
        {
            this.Competences = competences;
        }

        ///Propriéte de l'attibut qui sert de liste de compétences du mécanicien
        public List<Competences> Competences
        {
            get { return this.competences; }
            set { this.competences = value; }
        }

        ///Methode pour ajouter une compétence pour le mecanicien
        private void AjouterCompetence(Competences _competence)
        {
            ///Ajouter si la compétences n'est pas encore sur les siens
            if (!this.EstCompetentPour(_competence) && _competence.Competence != "")
            {
                this.Competences.Add(_competence);
            }
        }

        ///Le mecanicien peut apprendre de nouvelles compétences, on fait appel ici à la methode AjouterCompetences()
        public void ApprendreNouvelleCompetence(Competences _competence) => this.AjouterCompetence(_competence);

        ///Une booleenne pour vérifier si le mecanicien et compétent pour réparer une panne
        public bool EstCompetentPour(Competences _competence)
        {
            string compet = _competence.Competence;
            for (int i = 0; i < this.Competences.Count; i++)
            {
                if (this.Competences[i].Competence == compet)
                {
                    return true;
                }
            }
            return false;
        }

        ///Il répare la voiture, une methode appelée uniquement si la précedente est vraie
        public void Reparer(Voiture voiture)
        {
            voiture.EnPanne = false;
            voiture.Panne = "";
        }

        ///Stocker les informations du mécanicien dans une methode qui sera concaténée à la methode
        ///virtuelle d'affichage de la classe Personne
        private string InformationsMecano()
        {
            string infos = $"Compétences : ";
            if (this.Competences.Count > 0)
            {
                for (int i = 0; i < this.Competences.Count; i++)
                {
                    infos += $"\n\t{i + 1} - {this.Competences[i].Competence}";
                }
            }
            else
            {
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

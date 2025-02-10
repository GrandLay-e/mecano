using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    public class Client : Personne
    {
        /// Un client a des voitures
        public List<Voiture> voitures = new List<Voiture>();
        public Client()
        {
            this.voitures = new List<Voiture>();
        }
        public Client(string nom,
                      string prenom,
                      string adresse,
                      List<Voiture> voitures) :
                     base(nom,
                          prenom,
                          adresse)
        {
            this.voitures = voitures;
        }

        ///Il peut demander une réparation d'une voiture à un mécanicien
        public string DemanderReparation(Voiture vtr, Mecanicien mecano)
        {
            ///On récupère ici la panne de la voiture pour définir la compétence necessaire
            ///Je pourrait faire des compétences et des pannes, mais peut-être prochainement
            ///Je dois réviser autre chose
            Competences _competence = new Competences(vtr.panne);  
            Reparation _repair = new Reparation(new List<Competences> {_competence});

            ///Parcours des compétences necessaires (ici une seule)
            foreach(var compet in _repair.competencesNecessaires)
            {
                ///Si le mecano choisi n'est pas compétent pour réparer la voiture
                ///On le signale au client
                if (!mecano.EstCompetentPour(compet))
                {
                    return $"Le mécano {mecano.lastName} {mecano.firstName} " +
                        $"n'a pas les compétences requises pour effectuer cette reparation ! \n";
                }
            }
            ///Si on arrive ici, c'est qu'il est compétent pour le faire
            ///Donc il répare la voiture et on envoie les message au client
            mecano.Reparer(vtr);
            return $"Votre voiture {vtr.marque} a été reparée avec succès par {mecano.lastName} " +
                $"{mecano.firstName}\n";
        }


        ///Methode heritée de la classe personne pour afficher les informations du client
        public override string AfficherInfos()
        {
            string details = "Voitures : \n";
            for (int i = 0; i < voitures.Count; i++)
            {
                details += $"\n\t{i+1} - " + voitures[i].AfficherVoiture();
            }
            return base.AfficherInfos() + details;
        }
    }
}

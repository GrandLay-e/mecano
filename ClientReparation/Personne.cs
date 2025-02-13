using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{

    /// Classe abstraite personne de laquelle vont heriter Mecanicien et clien
    public abstract class Personne
    {
        private string firstName;
        private string lastName;
        private string adress;

        ///Constructeur pas défaut
        public Personne()
        {
            this.firstName = "";
            this.lastName = "";
            this.adress = "";
        }

        ///Constructeur principal
        public Personne(string firstName, string lastName, string adress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
        }
        
        public string FirstName
        {
            get {  return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Adresse
        {
            get { return this.adress; }
            set { this.adress = value; }
        }

        ///Methode virtuel pour afficher les informations primaires d'une personne
        public virtual string AfficherInfos()
        {
            return $"Prénom et Nom {this.FirstName} {this.LastName}\n" +
               $"Adresse : {this.Adresse}\n";
        }
    }
}

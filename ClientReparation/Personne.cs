using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{

    /// <summary>
    /// Classe abstraite personne de laquelle vont heriter Mecanicien et clien
    /// </summary>
    public abstract class Personne
    {
        public string firstName; 
        public string lastName;
        public string adress;

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

        ///Methode virtuel pour afficher les informations primaires d'une personne
        public virtual string AfficherInfos()
        {
            return $"Prénom et Nom {this.firstName} {this.lastName}\n" +
               $"Adresse : {this.adress}\n";
        }
    }
}

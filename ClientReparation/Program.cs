using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientReparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture vtr = new Voiture("Audi","PA-750-RIS",false);
            Voiture vtr2 = new Voiture("Ford","PA-756-LY",false);
            Voiture vtr3 = new Voiture("Clio","PA-757-FR",false);
            vtr3.AjouterPanne("Amortisseur");
            vtr2.AjouterPanne("Moteur");

            List<Voiture> voitures = new List<Voiture>() { vtr, vtr2, vtr3 };
            Client client = new Client("Dupont", "Patrick", "Paris 75000", voitures);
            Console.WriteLine("_______________________________________");
            Console.WriteLine(client.AfficherInfos());

            Console.WriteLine("_______________________________________");
            Mecanicien mecano = new Mecanicien("Laye", "Grand", "Marseille", new List<Competences>());
            Console.WriteLine(mecano.AfficherInfos());
            
            Console.WriteLine(vtr2.Panne);
            Console.WriteLine(vtr3.Panne);
            Console.WriteLine(client.DemanderReparation(vtr3, mecano));
            mecano.ApprendreNouvelleCompetence(new Competences(vtr2.Panne));
            mecano.ApprendreNouvelleCompetence(new Competences(vtr3.Panne));
            mecano.ApprendreNouvelleCompetence(new Competences(vtr.Panne));
            Console.WriteLine(client.DemanderReparation(vtr3, mecano));
            Console.WriteLine(mecano.AfficherInfos());
        }
        
    }
}

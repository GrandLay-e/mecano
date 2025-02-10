ClientReparation

Ce projet est un exercice de programmation orientée objet (POO) réalisé dans le cadre du BTS SIO. Il met en œuvre des concepts UML tels que l'héritage, les associations et les collections pour modéliser un système de gestion de réparations automobiles.

Description du projet

Le projet simule un système où un client peut demander la réparation de sa voiture à un mécanicien. Les mécaniciens possèdent des compétences spécifiques pour réparer différents types de pannes. Le projet illustre l'utilisation des classes, de l'héritage, des collections et des méthodes pour gérer les interactions entre les objets.

Structure du projet

Le projet est organisé en plusieurs classes :

- Personne : Classe abstraite représentant une personne avec un prénom, un nom et une adresse.
- Client : Hérite de `Personne` et représente un client possédant une liste de voitures.
- Mecanicien : Hérite de `Personne` et représente un mécanicien avec une liste de compétences.
- Voiture : Représente une voiture avec une marque, un matricule, et un état de panne.
- Competences : Représente une compétence qu'un mécanicien peut posséder.
- Reparation : Représente une réparation nécessitant certaines compétences.
- Program : Classe principale contenant la méthode `Main` pour exécuter le programme.

Fonctionnalités

- Un client peut demander la réparation d'une voiture à un mécanicien.
- Un mécanicien peut apprendre de nouvelles compétences.
- Un mécanicien ne peut réparer une voiture que s'il possède les compétences nécessaires.
- Affichage des informations des clients, des mécaniciens et des voitures.

Exemple d'utilisation


Voiture vtr = new Voiture("Audi", "PA-750-RIS", false);
Voiture vtr2 = new Voiture("Ford", "PA-756-LY", false);
Voiture vtr3 = new Voiture("Clio", "PA-757-FR", false);
vtr3.AjouterPanne("Amortisseur");
vtr2.AjouterPanne("Moteur");

List<Voiture> voitures = new List<Voiture>() { vtr, vtr2, vtr3 };
Client client = new Client("Dupont", "Jean", "123 Rue de Paris", voitures);
Console.WriteLine(client.AfficherInfos());

Mecanicien mecano = new Mecanicien("Martin", "Pierre", "456 Rue de Lyon", new List<Competences>());
Console.WriteLine(mecano.AfficherInfos());

Console.WriteLine(client.DemanderReparation(vtr3, mecano));
mecano.ApprendreNouvelleCompetence(new Competences(vtr2.panne));
mecano.ApprendreNouvelleCompetence(new Competences(vtr3.panne));
Console.WriteLine(client.DemanderReparation(vtr3, mecano));
Console.WriteLine(mecano.AfficherInfos());

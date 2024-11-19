using System;

namespace MonApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Initialisation de variables
            string userAnswer = "";

            //Création de jeu de données
            List<Voiture> lesVoitures = new List<Voiture>();

            lesVoitures.Add(new Voiture("MG", "MG4", 2022, "Blanche"));
            lesVoitures.Add(new Voiture("Mistubishi", "EVO X", 2009, "Rouge"));
            lesVoitures.Add(new Voiture("Toyota", "Supra", 2001, "Orange"));
            lesVoitures.Add(new Voiture("Mazda", "MX-7", 2004, "Bleue"));
            lesVoitures.Add(new Voiture("BMW", "M8 Compétition Gran Coupe", 2018, "Verte"));
            lesVoitures.Add(new Voiture("Volkswagen", "Golf 7", 2020, "Grise"));

            //Intéraction utilisateur
            Console.Write("\n\nAvez-vous déjà roulé ou croisé une de ces voitures là ? (Oui/Non)\n");
            foreach (Voiture voiture in lesVoitures)
            {
                Console.WriteLine($"{voiture.Marque} {voiture.Modele}");
            }

            while(!IsUserAnswerYesOrNo(userAnswer))
            {
                userAnswer = Console.ReadLine();
            }
            userAnswer = "";
            Console.Write("\n\nVoulez-vous ajouter à cette liste une voiture que vous avez vu et aimé ? (Oui/Non)\n");

            while(!IsUserAnswerYesOrNo(userAnswer))
            {
                userAnswer = Console.ReadLine();
            }

            if (userAnswer == "Oui")
            {
                Console.Write("\n\nDe quelle marque est cette voiture ?\n");
                string marqueVoiture = Console.ReadLine();
                Console.Write($"\n\nQuel modèle de {marqueVoiture} est-ce ?\n");
                string modeleVoiture = Console.ReadLine();
                Console.Write($"\n\nEn quelle année la {marqueVoiture} {modeleVoiture} est sortie ?\n");
                string anneeVoitureString = Console.ReadLine();
                int anneeVoiture = int.Parse(anneeVoitureString);
                Console.Write($"\n\nQuelle est la couleur que vous préférez sur la {marqueVoiture} {modeleVoiture} ?\n");
                string couleurVoiture = Console.ReadLine();

                lesVoitures.Add(new Voiture(marqueVoiture, modeleVoiture, anneeVoiture, couleurVoiture));
                Console.WriteLine("\nVoiture enregistrée\n");

            }


            foreach (Voiture voiture in lesVoitures)
            {
                Console.WriteLine($" - {voiture.Marque} {voiture.Modele}");
            }

            Console.WriteLine("Fin du questionnaire.");

        }

        static bool IsUserAnswerYesOrNo(string userAnswer)
        {
            if (userAnswer == "Oui" || userAnswer == "Non")
            {
                return true;
            }
            if (userAnswer != "")
            {
                Console.WriteLine("Format de réponse non valide");
            }
            return false;
        }
    }

    public class Voiture
    {

        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Annee { get; set; }
        public string Couleur { get; set; }

        public Voiture(string marque, string modele, int annee, string couleur)
        {
            Marque = marque;
            Modele = modele;
            Annee = annee;
            Couleur = couleur;
        }

    }

}
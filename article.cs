using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cour1.ArticleType;

namespace cour1
{
    // Déclaration de la structure Article
    public class article
    {
        public string Designation { get; set; }
        public double Prix { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public TypeArticle Type { get; set; }

        // Constructeur
        public article(string designation, double prix, string nom, int quantite, TypeArticle type)
        {
            this.Designation = designation;
            this.Prix = prix;
            this.Nom = nom;
            this.Quantite = quantite;
            this.Type = type;

        }

        public void acheter()
        {
            Console.WriteLine("Article acheté");
        }


        // Méthode pour afficher les informations de l'article
        public void Afficher()
        {
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Prix: " + Prix);
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Quantité: " + Quantite);
            Console.WriteLine($"Nom: {Nom}, Prix: {Prix}, Quantité: {Quantite}");
            Console.WriteLine($"Nom: {Nom}, Prix: {Prix}, Quantité: {Quantite}");
        }

        // Méthode pour ajouter à la quantité disponible
        public void Ajouter(int quantiteAjoutee)
        {
            if (quantiteAjoutee > 0)
                Quantite += quantiteAjoutee;
            else
                Console.WriteLine("Erreur : la quantité ajoutée doit être un nombre entier positif.");

        }

        // Méthode pour retirer de la quantité disponible
        public void Retirer(int quantiteRetiree)
        {
            if (quantiteRetiree > 0 && quantiteRetiree <= Quantite)
                Quantite -= quantiteRetiree;
            else
                Console.WriteLine("Erreur : la quantité retirée doit être un nombre entier positif et ne peut pas dépasser la quantité disponible.");
        }

        public class Livre : article
        {
            private string isbn;
            private int nbPages;

            public Livre(string designation, double prix, string nom, int quantite, string isbn, int nbPages, TypeArticle type) : base(designation, prix, nom, quantite, type)
            {
                this.isbn = isbn;
                this.nbPages = nbPages;
            }
        }

        public class Disque : article
        {
            private string label;

            public Disque(string designation, double prix, string nom, int quantite, string label, TypeArticle type) : base(designation, prix, nom, quantite, type)
            {
                this.label = label;
            }

            public void ecouter()
            {
                Console.WriteLine("Disque écouté");
            }
        }

        public class Video : article
        {
            private int duree;

            public Video(string designation, double prix, string nom, int quantite, int duree) : base(designation, prix, nom, quantite, TypeArticle.Alimentaire)
            {
                this.duree = duree;
            }

            public void afficher()
            {
                Console.WriteLine("Vidéo affichée");
            }
        }

        public class Poche : Livre
        {
            private string categorie;

            public Poche(string designation, double prix, string nom, int quantite, string isbn, int nbPages, string categorie, TypeArticle type) : base(designation, prix, isbn, nbPages, nom, quantite, type)
            {
                this.categorie = categorie;
            }
        }

        public class Broche : Livre
        {
            public Broche(string designation, double prix, string nom, int quantite, string isbn, int nbPages, TypeArticle type) : base(designation, prix, isbn, nbPages, nom, quantite, type)
            {
            }
        }
    }
}

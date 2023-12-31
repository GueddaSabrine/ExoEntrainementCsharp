using cour1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cour1.articleTableau;
using static cour1.ArticleDAO;

namespace cour1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*     
            article monArticle = new article("Produit 1", 20, "Fontaine", 5);
            monArticle.acheter();

            Livre monLivre = new Livre("Livre 1", 19, "Victor", 5, "ISBN123", 200);
            monLivre.acheter();

            Disque monDisque = new Disque("Disque 1", 13, "Hugo", 5, "LabelXYZ");
            monDisque.acheter();
            monDisque.ecouter();

            Video maVideo = new Video("Vidéo 1", 17, "Eric", 5, 120);
            maVideo.acheter();
            maVideo.afficher();


            Poche monPoche = new Poche("Livre de poche", 12, "Rosa", 5, "ISBN456", 150, "Texte");
            monPoche.acheter();

            Broche maBroche = new Broche("Livre broché", 10, "Hélène", 5, "ISBN789", 250);
            maBroche.acheter();
            */



            /*
            // Création de deux articles
            article article1 = new article("Article1", 10.99, "art1", 20, ArticleType.TypeArticle.Alimentaire);
            article article2 = new article("Article2", 5.49, "art2", 30, ArticleType.TypeArticle.Droguerie);

            // Affichage des articles
            Console.WriteLine("Articles avant modification :");
            article1.Afficher();
            article2.Afficher();

            // Modification des quantités
            article1.Ajouter(5);
            article2.Retirer(3);

            // Affichage des articles après modification
            Console.WriteLine("\nArticles après modification :");
            article1.Afficher();
            article2.Afficher();

            // Test de création d'un nouvel article par l'utilisateur
            Console.WriteLine("\nCréation d'un nouvel article :");
            Console.Write("Nom de l'article : ");
            string nom = Console.ReadLine();

            Console.Write("Prix de l'article : ");
            double prix;
            if (double.TryParse(Console.ReadLine(), out prix))
            {
                Console.Write("Quantité disponible : ");
                int quantite;
                if (int.TryParse(Console.ReadLine(), out quantite))
                {
                    // Création de l'article avec les informations saisies
                    article nouvelArticle = new article(null, prix, nom, quantite, ArticleType.TypeArticle.Loisir);

                    // Affichage de l'article créé
                    Console.WriteLine("\nNouvel article créé :");
                    nouvelArticle.Afficher();
                }
                else
                {
                    Console.WriteLine("Erreur : La quantité doit être un nombre entier.");
                }
            }
            else
            {
                Console.WriteLine("Erreur : Le prix doit être un nombre décimal.");
            }



            //Tableau de trois articles
            ArticleTypé[] articles = new ArticleTypé[3];
            articles[0] = new ArticleTypé("Article 1", 10.0, 5, ArticleType.TypeArticle.Loisir);
            articles[1] = new ArticleTypé("Article 2", 20.0, 10, ArticleType.TypeArticle.Habillement);
            articles[2] = new ArticleTypé("Article 3", 30.0, 15, ArticleType.TypeArticle.Droguerie);

            for (int i = 0; i < articles.Length; i++)
            {
                articles[i].Afficher();
                Console.WriteLine();
            }

        }
            */

        

            /*
            //ArticleDAO
            articleDAO articleDAO = new articleDAO();

            // Ajouter quelques articles pour tester
            articleDAO.AjouterArticle(new Article ("Article 1", 10.0, 5, TypeArticle.Alimentaire
            ));
            articleDAO.AjouterArticle(new Article { Nom = "Article 2", Prix = 20.0, Quantite = 10, Type = TypeArticle.Habillement
            });


            // Obtenir et afficher tous les articles
            List<Article> tousLesArticles = articleDAO.ObtenirTousLesArticles();
            foreach (var article in tousLesArticles)
            {
            Console.WriteLine($"Nom : {article.Nom}, Prix : {article.Prix}, Quantité : {article.Quantite}, Type : {article.Type}");
            }
            */

            //ArticleDAO
            ArticleDAO articleDAO = new ArticleDAO();
            article article1 = new article("Article1", 10.99, "art1", 20, ArticleType.TypeArticle.Alimentaire);

        //articleDAO.AjouterArticle(new Article("Article 1", 10.0, 5, TypeArticle.Alimentaire));

        
            // Ajouter quelques articles pour tester
            articleDAO.AjouterArticle(article1);
            /*Console.ReadLine();*/


            Dbutils db = new Dbutils();

            // Créer la table Article
            db.CreateArticleTable();

            Console.WriteLine("Table Article créée.");

            // Exemple d'achat
            /*db.Acheter("Article1", 5);*/

            db.CreateLivreTable();
            db.CreateDisqueTable();
            db.CreateVideoTable();

            // Insérer des données fictives dans la table Livre
            db.InsertDataIntoLivreTable(1, "1234567890", 300);
            db.InsertDataIntoLivreTable(2, "9876543210", 250);
            db.InsertDataIntoLivreTable(3, "5555555555", 400);

            // Insérer des données fictives dans la table Disque
            db.InsertDataIntoDisqueTable(4, "LabelXYZ");
            db.InsertDataIntoDisqueTable(5, "MusicCo");
            db.InsertDataIntoDisqueTable(6, "SoundWave");

            // Insérer des données fictives dans la table Video
            db.InsertDataIntoVideoTable(7, 120);
            db.InsertDataIntoVideoTable(8, 180);
            db.InsertDataIntoVideoTable(9, 90);

            Console.WriteLine("Données fictives insérées.");


            // Sélectionner un livre par ISBN
            /*db.SelectLivreByISBN("1234567890");

            // Sélectionner un disque par label
            db.SelectDisqueByLabel("LabelXYZ");

            // Sélectionner une vidéo par durée
            db.SelectVideoByDuree(120);*/


            // Mettre à jour le titre d'un livre
            db.UpdateLivreTitle(1, "Nouveau Titre");

            // Mettre à jour le réalisateur d'une vidéo
            db.UpdateVideoDirector(3, "Nouveau Réalisateur");



            // Supprimer tous les disques d'un certain genre
            db.DeleteDisquesByGenre("Rock");




            // Insérer des données fictives dans la table Article
            db.InsertDataIntoArticleTable(1, "Produit1", 10);
            db.InsertDataIntoArticleTable(2, "Produit2", 15);
            db.InsertDataIntoArticleTable(3, "Produit3", 20);
            db.InsertDataIntoArticleTable(4, "Produit4", 25);
            db.InsertDataIntoArticleTable(5, "Produit5", 30);
            db.InsertDataIntoArticleTable(6, "Produit6", 35);

            Console.WriteLine("Données fictives insérées dans la table Article.");






            // Autres opérations sur la base de données...

            Console.WriteLine("Opérations sur la base de données terminées.");

        }
    }
}

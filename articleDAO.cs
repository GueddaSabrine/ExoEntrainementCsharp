using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static cour1.ArticleType;
using static cour1.Program;

namespace cour1
{
    class ArticleDAO
    {



        private List<article> articles;

        public ArticleDAO()
        {
            // Initialiser la liste des articles
            articles = new List<article>();
            Console.WriteLine("hello construct");
        }

        public void AjouterArticle(article article)
        {
            // Ajouter un nouvel article à la liste
            articles.Add(article);
        }

        public List<article> ObtenirTousLesArticles()
        {
            // Retourner tous les articles
            return articles;
        }

        public article ObtenirArticleParNom(string nom)
        {
            // Rechercher un article par son nom
            return articles.Find(a => a.Nom == nom);
        }

        public void MettreAJourArticle(article article)
        {
            // Mettre à jour un article existant
            article articleExist = articles.Find(a => a.Nom == article.Nom);
            if (articleExist != null)
            {
                articleExist.Prix = article.Prix;
                articleExist.Quantite = article.Quantite;
                articleExist.Type = article.Type;
            }
        }

        public void SupprimerArticle(string nom)
        {
            // Supprimer un article par son nom
            article article = articles.Find(a => a.Nom == nom);
            if (article != null)
            {
                articles.Remove(article);
            }
        }

    }
}

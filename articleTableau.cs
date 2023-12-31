using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cour1.ArticleType;

namespace cour1
{
    public class articleTableau
    {
        public struct ArticleTypé
        {
            public string nom;
            public double prix;
            public int quantite;
            public TypeArticle type;

            public ArticleTypé(string nom, double prix, int quantite, TypeArticle type)
            {
                this.nom = nom;
                this.prix = prix;
                this.quantite = quantite;
                this.type = type;
            }

            public void Afficher()
            {
                Console.WriteLine("Nom : " + nom);
                Console.WriteLine("Prix : " + prix);
                Console.WriteLine("Quantité : " + quantite);
                Console.WriteLine("Type : " + type);
            }

            public void Ajouter(int quantite)
            {
                this.quantite += quantite;
            }

            public void Retirer(int quantite)
            {
                this.quantite -= quantite;
            }
        }
    }
}

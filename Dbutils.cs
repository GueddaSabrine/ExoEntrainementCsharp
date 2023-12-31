using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cour1
{
    class Dbutils
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Dbutils()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "library";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=127.0.0.1;DATABASE=library;UID=root;PASSWORD=";

            connection = new MySqlConnection(connectionString);
        }

        // Ouvrir la connexion à la base de données
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Gérer les erreurs de connexion
                return false;
            }
        }

        // Fermer la connexion à la base de données
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Gérer les erreurs de fermeture de connexion
                return false;
            }
        }

        // Exécuter une commande MySQL
        public void ExecuteQuery(string query)
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Méthode pour créer une table Article
        public void CreateArticleTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Article (id INT PRIMARY KEY, designation VARCHAR(255), prix INT)";
            ExecuteQuery(createTableQuery);
        }

        /*public void Acheter(string designation, int prix)
        {
            // Vérifier si l'article existe
            string checkArticleQuery = $"SELECT * FROM Article WHERE designation = '{designation}'";
            MySqlCommand checkCmd = new MySqlCommand(checkArticleQuery, connection);

            if (OpenConnection())
            {
                using (MySqlDataReader reader = checkCmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine($"L'article '{designation}' n'existe pas.");
                        CloseConnection();
                        return;
                    }
                }
                CloseConnection();
            }

            // Effectuer l'achat
            string acheterQuery = $"UPDATE Article SET prix = prix * {prix} WHERE designation = '{designation}'";

            ExecuteQuery(acheterQuery);

            Console.WriteLine($"Achat de {prix} unité(s) de '{designation}' effectué.");
        }*/





        public void CreateLivreTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Livre (id INT PRIMARY KEY, isbn VARCHAR(20), nbPages INT, FOREIGN KEY (id) REFERENCES Article(id))";
            ExecuteQuery(createTableQuery);
        }

        public void CreateDisqueTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Disque (id INT PRIMARY KEY, label VARCHAR(255), FOREIGN KEY (id) REFERENCES Article(id))";
            ExecuteQuery(createTableQuery);
        }

        public void Ecouter(int articleId)
        {
            // Implémentez la logique pour la méthode Ecouter ici
            Console.WriteLine($"Ecoute de l'article avec l'ID {articleId} en cours...");
        }

        public void CreateVideoTable()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Video (id INT PRIMARY KEY, duree INT, FOREIGN KEY (id) REFERENCES Article(id))";
            ExecuteQuery(createTableQuery);
        }

        public void Afficher(int articleId)
        {
            // Implémentez la logique pour la méthode Afficher ici
            Console.WriteLine($"Affichage de l'article avec l'ID {articleId} en cours...");
        }




        public void InsertDataIntoLivreTable(int id, string isbn, int nbPages)
        {
            string insertDataQuery = $"INSERT INTO Livre (id, isbn, nbPages) VALUES ({id}, '{isbn}', {nbPages})";
            ExecuteQuery(insertDataQuery);
        }

        // Méthode pour insérer des données fictives dans la table Disque
        public void InsertDataIntoDisqueTable(int id, string label)
        {
            string insertDataQuery = $"INSERT INTO Disque (id, label) VALUES ({id}, '{label}')";
            ExecuteQuery(insertDataQuery);
        }

        // Méthode pour insérer des données fictives dans la table Video
        public void InsertDataIntoVideoTable(int id, int duree)
        {
            string insertDataQuery = $"INSERT INTO Video (id, duree) VALUES ({id}, {duree})";
            ExecuteQuery(insertDataQuery);
        }



        // Méthode pour sélectionner un livre par ISBN
        /*public void SelectLivreByISBN(string isbn)
        {
            string selectQuery = $"SELECT * FROM Livre WHERE isbn = '{isbn}'";
            ExecuteSelectQuery(selectQuery);
        }

        // Méthode pour sélectionner un disque par label
        public void SelectDisqueByLabel(string label)
        {
            string selectQuery = $"SELECT * FROM Disque WHERE label = '{label}'";
            ExecuteSelectQuery(selectQuery);
        }

        // Méthode pour sélectionner une vidéo par durée
        public void SelectVideoByDuree(int duree)
        {
            string selectQuery = $"SELECT * FROM Video WHERE duree = {duree}";
            ExecuteSelectQuery(selectQuery);
        }*/

        /*private void ExecuteSelectQuery(string query)
        {
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Manipuler les données lues depuis la base de données
                        Console.WriteLine($"ID: {reader["id"]}, AutreColonne: {reader["autre_colonne"]}, ...");
                    }
                }
                CloseConnection();
            }
        }*/


        // Méthode pour mettre à jour le titre d'un livre
        public void UpdateLivreTitle(int livreId, string newTitle)
        {
            string updateQuery = $"UPDATE Livre SET designation = '{newTitle}' WHERE id = {livreId}";
            ExecuteQuery(updateQuery);
        }

        // Méthode pour mettre à jour le réalisateur d'une vidéo
        public void UpdateVideoDirector(int videoId, string newDirector)
        {
            string updateQuery = $"UPDATE Video SET realisateur = '{newDirector}' WHERE id = {videoId}";
            ExecuteQuery(updateQuery);
        }




        // Méthode pour supprimer tous les disques d'un certain genre
        public void DeleteDisquesByGenre(string genre)
        {
            string deleteQuery = $"DELETE FROM Disque WHERE genre = '{genre}'";
            ExecuteQuery(deleteQuery);
        }




        // Méthode pour insérer des données fictives dans la table Article
        public void InsertDataIntoArticleTable(int id, string designation, int prix)
        {
            string insertDataQuery = $"INSERT INTO Article (id, designation, prix) VALUES ({id}, '{designation}', {prix})";
            ExecuteQuery(insertDataQuery);
        }


        //MySqlConnection connection;
        //string connectionString = "SERVER=127.0.0.1;DATABASE=library;UID=root;PASSWORD="; 

        //public void methode()
        //{
        //this.connection = new MySqlConnection(connectionString);
        //connection.Open();
        //}
    }
}

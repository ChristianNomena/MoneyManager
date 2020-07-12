using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMoney
{
    public class Connection
    {
        public static void Database_Initialization()
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            MySqlDataReader myReader;

            // Initilisation de la base des données et création des tables
            try
            {
                try
                {
                    // Test de connexion à la BD
                    myConnection.Open();

                    // Tentative de lecture à la BD pour vérifier si les tables ont déjà été créées
                    string myRequest = "SELECT id_utilisateur FROM utilisateur";
                    MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                    myReader = myCommand.ExecuteReader();
                    myReader.Close();
                }

                
                catch (Exception e)
                {
                    try
                    {
                        // Création de la base de données dans le SGBD au cas où elle n'est pas encore été créée
                        MySqlConnection myNewConnection = new MySqlConnection("Server=localhost;Database=;Uid=root;Pwd=;");
                        myNewConnection.Open();

                        string myNewRequest = "CREATE DATABASE moneymanager";
                        MySqlCommand myNewCommand = new MySqlCommand(myNewRequest, myNewConnection);

                        myNewCommand.ExecuteNonQuery();
                        myNewCommand.Dispose();

                        myNewConnection.Close();
                        myConnection.Close();
                    }
                    catch (Exception except)
                    {
                        // Arrêt Immédiat
                    }

                    // Création des tables nécessaires si elles n'ont pas encore été créées
                    string myRequest = "CREATE TABLE utilisateur(" +
                                           "id_utilisateur Int Auto_increment NOT NULL ," +
                                           "pseudo_utilisateur Varchar (200) NOT NULL ," +
                                           "password_utilisateur Varchar(255) NOT NULL," +
                                           "valeur_portefeuille_utilisateur Double NOT NULL ," +
                                           "pourcentage_economie_utilisateur Int NOT NULL," +
                                           "valeur_economie_utilisateur Double NOT NULL" +
                                           ", CONSTRAINT utilisateur_PK PRIMARY KEY(id_utilisateur)" +
                                       ")ENGINE = InnoDB; " +
                                       "" +
                                       "CREATE TABLE budget(" +
                                           "id_budget Int  Auto_increment NOT NULL ," +
                                           "valeur_budget Double NOT NULL," +
                                           "date_ajout_budget Date NOT NULL," +
                                           "id_utilisateur Int NOT NULL" +
                                           ", CONSTRAINT budget_PK PRIMARY KEY(id_budget)" +
                                           ", CONSTRAINT budget_utilisateur_FK FOREIGN KEY(id_utilisateur) REFERENCES utilisateur(id_utilisateur)" +
                                       ")ENGINE = InnoDB; " +
                                       "" +
                                       "CREATE TABLE achat(" +
                                           "id_achat Int  Auto_increment NOT NULL ," +
                                           "valeur_achat Double NOT NULL," +
                                           "detail_achat   Text ," +
                                           "date_achat Date NOT NULL," +
                                           "id_utilisateur Int NOT NULL" +
                                           ", CONSTRAINT achat_PK PRIMARY KEY(id_achat)" +
                                           ", CONSTRAINT achat_utilisateur_FK FOREIGN KEY(id_utilisateur) REFERENCES utilisateur(id_utilisateur)" +
                                       ")ENGINE = InnoDB; ";

                    MySqlConnection myTableConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
                    myTableConnection.Open();

                    MySqlCommand myCommand = new MySqlCommand(myRequest, myTableConnection);
                    myCommand.ExecuteNonQuery();

                    myCommand.Dispose();
                    myTableConnection.Close();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Veuillez vérifier que vous disposez bien d'une SBGD MySQL ou MariaDB sur votre ordinateur", "Connexion à la base de données non établie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool Connection_User(string pseudo, string password)
        {
            bool connected = false;
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT * FROM utilisateur";
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.GetString(1) == pseudo && myReader.GetString(2) == password)
                    {
                        connected = true;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return connected;
        }

    }
}

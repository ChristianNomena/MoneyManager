using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMoney
{
    class Utilisateur
    {
        public static bool userConnected = false;

        private int id_utilisateur;
        private string pseudo_utilisateur;
        private string password_utilisateur;

        private double valeur_portefeuille_utilisateur;
        private int pourcentage_economie_utilisateur;
        private double valeur_economie_utilisateur;

        // =============== Accesseurs ===============
        public int getId()
        {
            return this.id_utilisateur;
        }

        public string getPseudo()
        {
            return this.pseudo_utilisateur;
        }

        public string getPassword()
        {
            return this.password_utilisateur;
        }

        public double getValeurPortefeuille()
        {
            return this.valeur_portefeuille_utilisateur;
        }

        public int getPourcentageEconomie()
        {
            return this.pourcentage_economie_utilisateur;
        }

        public double getValeurEconomie()
        {
            return this.valeur_economie_utilisateur;
        }

        // =============== Mutateurs ===============
        public void setId(int id)
        {
            this.id_utilisateur = id;
        }

        public void setPseudo(string pseudo)
        {
            this.pseudo_utilisateur = pseudo;
        }

        public void setPassword(string password)
        {
            this.password_utilisateur = password;
        }

        public void setValeurPortefeuille(double valeur)
        {
            this.valeur_portefeuille_utilisateur = valeur;
        }

        public void setPourcentageEconomie(int pourcentage)
        {
            this.pourcentage_economie_utilisateur = pourcentage;
        }

        public void setValeurEconomie(double valeur)
        {
            this.valeur_economie_utilisateur = valeur;
        }

        public void Update_Profil()
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "UPDATE utilisateur " +
                                   "SET pseudo_utilisateur = '" + this.getPseudo() + "', password_utilisateur = '" + this.getPassword() + "' " +
                                   "WHERE id_utilisateur = " + this.getId();
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Update_Portefeuille()
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "UPDATE utilisateur " +
                                   "SET valeur_portefeuille_utilisateur = " + this.getValeurPortefeuille() + " " +
                                   "WHERE id_utilisateur = " + this.getId();
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Refresh_Utilisateur()
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT * FROM utilisateur WHERE id_utilisateur = " + this.getId();
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    this.setId(myReader.GetInt32(0));
                    this.setPseudo(myReader.GetString(1));
                    this.setPassword(myReader.GetString(2));
                    this.setValeurPortefeuille(myReader.GetDouble(3));
                    this.setPourcentageEconomie(myReader.GetInt32(4));
                    this.setValeurEconomie(myReader.GetDouble(5));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Affectation_Utilisateur(string pseudo, string password)
        {
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
                        this.setId(myReader.GetInt32(0));
                        this.setPseudo(pseudo);
                        this.setPassword(myReader.GetString(2));
                        this.setValeurPortefeuille(myReader.GetDouble(3));
                        this.setPourcentageEconomie(myReader.GetInt32(4));
                        this.setValeurEconomie(myReader.GetDouble(5));
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // =============== Méthodes de classe ===============
        public static void Inscription_Utilisateur(string pseudo_utilisateur, string password_utilisateur)
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "INSERT INTO utilisateur (pseudo_utilisateur, password_utilisateur, valeur_portefeuille_utilisateur, pourcentage_economie_utilisateur, valeur_economie_utilisateur)" +
                                   "VALUES ('" + pseudo_utilisateur + "', '" + password_utilisateur + "', 0, 0, 0)";
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Utilisateur créé avec succès", "Inscription Utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void Restauration_Utilisateur()
        {
            userConnected = false;
        }
    }
}

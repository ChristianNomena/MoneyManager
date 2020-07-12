using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMoney
{
    class Budget
    {
        private double valeur_budget;

        public Budget(double valeur_budget)
        {
            this.valeur_budget = valeur_budget;
        }

        public void setValeurBudget(double valeur) => this.valeur_budget = valeur;

        public double getValeurBudget() => this.valeur_budget;

        public void Ajouter_Budget(double portefeuille, double economie, int pourcentage, int id)
        {
            double realEconomie = (this.valeur_budget * pourcentage) / 100;
            double realPortefeuille = (this.valeur_budget - realEconomie) + portefeuille;
            realEconomie += economie;

            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "INSERT INTO budget (valeur_budget, date_ajout_budget, id_utilisateur)" +
                                   "VALUES (" + this.valeur_budget + ", now(), " + id + ")";
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();

                this.Update_Portefeuille(realPortefeuille, realEconomie, id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Update_Portefeuille(double valeurPortefeuille, double valeurEconomie, int id)
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "UPDATE utilisateur " +
                                   "SET valeur_portefeuille_utilisateur = " + valeurPortefeuille + ", valeur_economie_utilisateur = " + valeurEconomie + " " +
                                   "WHERE id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        // =============== Méthodes de classe ===============
        public static void Initialisation_Budget(double budget, int pourcentage, double economie, int id)
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "UPDATE utilisateur " +
                                   "SET valeur_portefeuille_utilisateur = " + budget + ", pourcentage_economie_utilisateur = " + pourcentage + ", valeur_economie_utilisateur = " + economie + " " +
                                   "WHERE id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();

                myRequest = "INSERT INTO budget (valeur_budget, date_ajout_budget, id_utilisateur)" +
                             "VALUES (" + (budget + economie) + ", now(), " + id + ")";
                myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static double Recuperation_Valeur_Total_Budget(int id)
        {
            double total_budget = 0;

            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT valeur_budget " +
                                   "FROM budget b " +
                                   "INNER JOIN utilisateur u " +
                                   "WHERE u.id_utilisateur = b.id_utilisateur " +
                                   "AND u.id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    total_budget += myReader.GetDouble(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return total_budget;
        }

        public static int Recuperation_Nombre_Budget(int id)
        {
            int nombre_budget = 0;

            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT COUNT(*) " +
                                   "FROM budget b " +
                                   "INNER JOIN utilisateur u " +
                                   "WHERE u.id_utilisateur = b.id_utilisateur " +
                                   "AND u.id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    nombre_budget = myReader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return nombre_budget;
        }

        public static void Affichage_Liste_Budget(DataGridView dataGridView, int id)
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT valeur_budget AS 'VALEUR BUDGET', date_ajout_budget AS 'DATE AJOUT BUDGET' " +
                                   "FROM budget b " +
                                   "INNER JOIN utilisateur u " +
                                   "WHERE u.id_utilisateur = b.id_utilisateur " +
                                   "AND u.id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand);
                DataSet myDataSet = new DataSet();

                try
                {
                    myAdapter.Fill(myDataSet, "Budget");

                    dataGridView.DataSource = myDataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

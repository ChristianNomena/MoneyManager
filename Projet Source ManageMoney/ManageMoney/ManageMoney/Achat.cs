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
    class Achat
    {
        private double valeur_achat;
        private string detail_achat;
        private DateTime date_achat;

        public Achat(double valeur_achat, string detail_achat, DateTime date_achat)
        {
            this.valeur_achat = valeur_achat;
            this.detail_achat = detail_achat;
            this.date_achat = date_achat;
        }

        public void Ajout_Achat(int id)
        {
            int annee = this.date_achat.Year;
            int mois = this.date_achat.Month;
            int jour = this.date_achat.Day;
            string dateAchat = annee + "-" + mois + "-" + jour;

            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "INSERT INTO Achat (valeur_achat, detail_achat, date_achat, id_utilisateur) " +
                                   "VALUES (" + this.valeur_achat + ", '" + this.detail_achat + "', '" + dateAchat + "' ," + id + ")";
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // =============== Méthodes de classe ===============
        public static double Recuperation_Valeur_Total_Achat(int id)
        {
            double total_achat = 0;

            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT valeur_achat " +
                                   "FROM achat a " +
                                   "INNER JOIN utilisateur u " +
                                   "WHERE u.id_utilisateur = a.id_utilisateur " +
                                   "AND u.id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    total_achat += myReader.GetDouble(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return total_achat;
        }

        public static int Recuperation_Nombre_Achat(int id)
        {
            int nombre_achat = 0;

            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT COUNT(*) " +
                                   "FROM achat a " +
                                   "INNER JOIN utilisateur u " +
                                   "WHERE u.id_utilisateur = a.id_utilisateur " +
                                   "AND u.id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    nombre_achat = myReader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return nombre_achat;
        }

        public static void Affichage_Liste_Achat(DataGridView dataGridView, int id)
        {
            MySqlConnection myConnection = new MySqlConnection("Server=localhost;Database=moneymanager;Uid=root;Pwd=;");
            myConnection.Open();

            try
            {
                string myRequest = "SELECT valeur_achat AS 'VALEUR ACHAT', detail_achat AS 'INFORMATION ACHAT', date_achat AS 'DATE ACHAT' " +
                                   "FROM achat a " +
                                   "INNER JOIN utilisateur u " +
                                   "WHERE u.id_utilisateur = a.id_utilisateur " +
                                   "AND u.id_utilisateur = " + id;
                MySqlCommand myCommand = new MySqlCommand(myRequest, myConnection);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand);
                DataSet myDataSet = new DataSet();

                try
                {
                    myAdapter.Fill(myDataSet, "Achat");

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

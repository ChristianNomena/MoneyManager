using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMoney
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Connection.Database_Initialization();
        }

        private void link_to_panel_inscription_auth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_inscription_auth.Show();
            this.panel_connexion_auth.Hide();
        }

        private void link_to_panel_connexion_auth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_connexion_auth.Show();
            this.panel_inscription_auth.Hide();
        }

        private void button_exit_auth_Click(object sender, EventArgs e)
        {
            this.Exit_Application();
        }

        private void button_connexion_auth_Click(object sender, EventArgs e)
        {
            this.connectionUtilisateur();
        }

        private void button_inscription_auth_Click(object sender, EventArgs e)
        {
            this.inscriptionUtilisateur();
        }



        private void connectionUtilisateur()
        {
            if (Utilisateur.userConnected == true)
            {
                MessageBox.Show("Un utilisateur est encore en cours de connexion", "Tentative de connexion refusée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.text_pseudo_connexion_auth.Text != "" && this.text_password_connexion_auth.Text != "")
            {
                bool connected = Connection.Connection_User(this.text_pseudo_connexion_auth.Text, this.text_password_connexion_auth.Text);

                if (connected)
                {
                    MainForm mainForm = new MainForm(this.text_pseudo_connexion_auth.Text, this.text_password_connexion_auth.Text);
                    mainForm.Show();

                    this.text_password_connexion_auth.Clear();
                }
                else
                {
                    MessageBox.Show("Veuillez vérifier les informations entrées", "Tentative de connexion refusée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void inscriptionUtilisateur()
        {
            if (this.text_pseudo_inscription_auth.Text != "" && this.text_password_inscription_auth.Text != "")
            {
                Utilisateur.Inscription_Utilisateur(this.text_pseudo_inscription_auth.Text, this.text_password_inscription_auth.Text);

                this.text_pseudo_inscription_auth.Clear();
                this.text_password_inscription_auth.Clear();
            }
        }


        private void Exit_Application()
        {
            this.Close();
        }
    }
}

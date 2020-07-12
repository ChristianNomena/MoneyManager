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
    public partial class MainForm : Form
    {
        Utilisateur userActive = new Utilisateur();

        public MainForm(string pseudo, string password)
        {
            InitializeComponent();
            Ajuster_Emplacement_Panel();

            Utilisateur.userConnected = true;

            // Récupération des données de l'Utilisateur
            userActive.Affectation_Utilisateur(pseudo, password);

            // Affichage de l'introduction si l'utilisateur n'a pas encore fixée une politique d'économie
            this.label_pseudo_utilisateur.Text = userActive.getPseudo();
            if (userActive.getPourcentageEconomie() == 0)
            {
                this.panel_intro.Show();
            }
            else
            {
                this.Chargement_Accueil();
            }
        }

        private void Ajuster_Emplacement_Panel()
        {
            this.panel_intro.Left = 240;
            this.panel_intro.Top = 56;

            this.panel_profil.Left = 240;
            this.panel_profil.Top = 56;

            this.panel_home.Left = 240;
            this.panel_home.Top = 56;

            this.panel_budget.Left = 240;
            this.panel_budget.Top = 56;

            this.panel_purchase.Left = 240;
            this.panel_purchase.Top = 56;

            this.panel_lists.Left = 235;
            this.panel_lists.Top = 56;

            this.panel_list_budget.Left = 0;
            this.panel_list_budget.Top = 74;

            this.panel_list_achat.Left = 0;
            this.panel_list_achat.Top = 74;
        }


        private void button_exit_main_Click(object sender, EventArgs e)
        {
            this.Exit_Main_From();
        }

        private void button_deconnexion_main_Click(object sender, EventArgs e)
        {
            this.Exit_Main_From();
        }

        // =============== INTRODUCTION ===============
        private void button_terminer_intro_Click(object sender, EventArgs e)
        {
            this.validationIntro();
        }

        private void validationIntro()
        {
            string budget = this.text_budget_intro.Text;
            string pourcentage = this.text_pourcentage_intro.Text;

            bool isBudgetDigit = true;
            bool isPourcentageDigit = true;

            for (int i = 0; i < budget.Length; i++)
            {
                if (char.IsDigit(budget[i]) == false)
                {
                    isBudgetDigit = false;
                    break;
                }
            }

            for (int i = 0; i < pourcentage.Length; i++)
            {
                if (char.IsDigit(pourcentage[i]) == false)
                {
                    isPourcentageDigit = false;
                    break;
                }
            }

            if ((isBudgetDigit && isPourcentageDigit) == false)
            {
                MessageBox.Show("Veuillez vérifier les valeurs entrées", "Information incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double realBudget = Convert.ToDouble(budget);
                int realPourcentage = Convert.ToInt32(pourcentage);
                double realEconomie = (realBudget * realPourcentage) / 100;
                realBudget -= realEconomie;

                if (realBudget <= 0 || (realPourcentage < 0 || realPourcentage > 50))
                {
                    MessageBox.Show("Les valeurs entrées ont une erreur", "Information incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Budget.Initialisation_Budget(realBudget, realPourcentage, realEconomie, userActive.getId());
                    this.panel_intro.Hide();
                    this.Chargement_Accueil();

                    MessageBox.Show("Vous pouvez maintenant commencer à utiliser le logiciel", "Première étape complète", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    userActive.Refresh_Utilisateur();
                    this.Chargement_Accueil();
                }
            }
        }

        // =============== PROFIL ===============
        private void button_modify_profil_Click(object sender, EventArgs e)
        {
            this.modificationProfil();
        }

        private void modificationProfil()
        {
            if (this.input_pseudo_profil.Text != "" && this.input_password_profil.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Les modifications seront apportées à votre profil. Voulez-vous continuer?", "Confirmation modification du profil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult.ToString() == "Yes")
                {
                    userActive.setPseudo(this.input_pseudo_profil.Text);
                    userActive.setPassword(this.input_password_profil.Text);
                    userActive.Update_Profil();

                    userActive.Refresh_Utilisateur();
                }
            }
            else
            {
                MessageBox.Show("Veuillez vérifier les valeurs entrées", "Information incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============== BUDGET ===============
        private void button_ajouter_budget_Click(object sender, EventArgs e)
        {
            this.ajoutBudget();
        }

        private void ajoutBudget()
        {
            string valeurBudget = this.input_valeur_budget.Text;
            bool isBudgetDigit = true;

            if (valeurBudget != "")
            {
                for (int i = 0; i < valeurBudget.Length; i++)
                {
                    if (char.IsDigit(valeurBudget[i]) == false)
                    {
                        isBudgetDigit = false;
                        break;
                    }
                }

                if (isBudgetDigit)
                {
                    DialogResult dialogResult = MessageBox.Show(valeurBudget + " Ar seront ajoutés. Êtes-vous sûr de vouloir continuer?", "Confirmation ajout budget", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult.ToString() == "Yes")
                    {
                        double realValeurBudget = Convert.ToDouble(valeurBudget);

                        Budget budget = new Budget(realValeurBudget);

                        budget.Ajouter_Budget(userActive.getValeurPortefeuille(), userActive.getValeurEconomie(), userActive.getPourcentageEconomie(), userActive.getId());

                        this.input_valeur_budget.Clear();

                        userActive.Refresh_Utilisateur();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez vérifier la valeur entrée", "Information incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =============== ACHAT ===============
        private void button_confirmer_achat_Click(object sender, EventArgs e)
        {
            this.confirmationAchat();
        }

        private void confirmationAchat()
        {
            if (this.input_valeur_achat.Text != "" && this.input_detail_achat.Text != "")
            {

                string valeurAchat = this.input_valeur_achat.Text;
                bool isAchatDigit = true;

                for (int i = 0; i < valeurAchat.Length; i++)
                {
                    if (char.IsDigit(valeurAchat[i]) == false)
                    {
                        isAchatDigit = false;
                        break;
                    }
                }

                if (isAchatDigit)
                {
                    double valeur_achat = Convert.ToDouble(this.input_valeur_achat.Text);
                    double valeur_portefeuille = userActive.getValeurPortefeuille();

                    Achat achat = new Achat(valeur_achat, this.input_detail_achat.Text, this.date_time_picker_achat.Value);

                    if (valeur_achat <= userActive.getValeurPortefeuille())
                    {
                        if (valeur_achat > 0)
                        {
                            valeur_portefeuille -= valeur_achat;

                            achat.Ajout_Achat(userActive.getId());
                            userActive.setValeurPortefeuille(valeur_portefeuille);
                            userActive.Update_Portefeuille();

                            this.input_valeur_achat.Clear();
                            this.input_detail_achat.Clear();

                            userActive.Refresh_Utilisateur();

                            MessageBox.Show("Achat ajouté dans la liste", "Achat effectué", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else
                        {
                            MessageBox.Show("La valeur de votre achat est incorrecte", "Information incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("La valeur de votre achat dépasse celle de votre portefeuille", "Information incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez vérifier la valeur entrée", "Information incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void link_to_panel_profil_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_home.Hide();
            this.panel_budget.Hide();
            this.panel_purchase.Hide();
            this.panel_lists.Hide();

            this.Chargement_Profil();
        }

        private void button_to_home_Click(object sender, EventArgs e)
        {
            this.panel_profil.Hide();
            this.panel_budget.Hide();
            this.panel_purchase.Hide();
            this.panel_lists.Hide();

            this.Chargement_Accueil();
        }

        private void button_to_budget_Click(object sender, EventArgs e)
        {
            this.panel_profil.Hide();
            this.panel_home.Hide();
            this.panel_purchase.Hide();
            this.panel_lists.Hide();

            this.panel_budget.Show();
        }

        private void button_to_purchase_Click(object sender, EventArgs e)
        {
            this.panel_profil.Hide();
            this.panel_home.Hide();
            this.panel_budget.Hide();
            this.panel_lists.Hide();

            this.panel_purchase.Show();
        }

        private void button_to_list_Click(object sender, EventArgs e)
        {
            this.panel_profil.Hide();
            this.panel_home.Hide();
            this.panel_budget.Hide();
            this.panel_purchase.Hide();

            Budget.Affichage_Liste_Budget(this.data_grid_view_budget, userActive.getId());
            Achat.Affichage_Liste_Achat(this.data_grid_view_purchase, userActive.getId());

            this.panel_lists.Show();
        }

        private void button_affichage_liste_budget_Click(object sender, EventArgs e)
        {
            this.panel_list_achat.Hide();
            this.panel_list_budget.Show();
        }

        private void button_affichage_liste_achat_Click(object sender, EventArgs e)
        {
            this.panel_list_budget.Hide();
            this.panel_list_achat.Show();
        }



        private void Exit_Main_From()
        {
            Utilisateur.Restauration_Utilisateur();
            this.Close();
        }

        private void Chargement_Profil()
        {
            userActive.Refresh_Utilisateur();

            this.input_pseudo_profil.Text = userActive.getPseudo();
            this.input_password_profil.Text = userActive.getPassword();

            this.input_valeur_portefeuille_profil.Text = (userActive.getValeurPortefeuille()).ToString() + " Ar";
            this.input_valeur_economie_profil.Text = (userActive.getValeurEconomie()).ToString() + " Ar";
            this.input_pourcentage_economie_profil.Text = (userActive.getPourcentageEconomie()).ToString() + " %";

            this.panel_profil.Show();
        }

        private void Chargement_Accueil()
        {
            userActive.Refresh_Utilisateur();

            double valeur_total_budget = Budget.Recuperation_Valeur_Total_Budget(userActive.getId());
            int nombre_budget_entre = Budget.Recuperation_Nombre_Budget(userActive.getId());

            double valeur_total_achat = Achat.Recuperation_Valeur_Total_Achat(userActive.getId());
            int nombre_achat_entre = Achat.Recuperation_Nombre_Achat(userActive.getId());

            this.text_valeur_portefeuille_home.Text = (userActive.getValeurPortefeuille()).ToString() + " Ar";
            this.text_valeur_economie_home.Text = (userActive.getValeurEconomie()).ToString() + " Ar";
            this.text_pourcentage_economie_home.Text = (userActive.getPourcentageEconomie()).ToString() + " %";

            this.text_total_budget_home.Text = valeur_total_budget.ToString() + " Ar";
            this.text_nombre_budget_home.Text = nombre_budget_entre.ToString();

            this.text_total_achat_home.Text = valeur_total_achat.ToString() + " Ar";
            this.text_nombre_achat_home.Text = nombre_achat_entre.ToString();

            this.panel_home.Show();
        }
    }
}

namespace ManageMoney
{
    partial class AuthForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.panel_header = new System.Windows.Forms.Panel();
            this.button_exit_auth = new System.Windows.Forms.PictureBox();
            this.label_title_auth = new System.Windows.Forms.Label();
            this.panel_connexion_auth = new System.Windows.Forms.Panel();
            this.link_to_panel_inscription_auth = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_connexion_auth = new System.Windows.Forms.Button();
            this.label_password_text = new System.Windows.Forms.Label();
            this.text_password_connexion_auth = new System.Windows.Forms.TextBox();
            this.label_email_text = new System.Windows.Forms.Label();
            this.text_pseudo_connexion_auth = new System.Windows.Forms.TextBox();
            this.label_connexion_text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_inscription_auth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.link_to_panel_connexion_auth = new System.Windows.Forms.LinkLabel();
            this.panel_inscription_auth = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.text_password_inscription_auth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_pseudo_inscription_auth = new System.Windows.Forms.TextBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_exit_auth)).BeginInit();
            this.panel_connexion_auth.SuspendLayout();
            this.panel_inscription_auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.panel_header.Controls.Add(this.button_exit_auth);
            this.panel_header.Controls.Add(this.label_title_auth);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(860, 50);
            this.panel_header.TabIndex = 1;
            // 
            // button_exit_auth
            // 
            this.button_exit_auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit_auth.Image = ((System.Drawing.Image)(resources.GetObject("button_exit_auth.Image")));
            this.button_exit_auth.Location = new System.Drawing.Point(812, 12);
            this.button_exit_auth.Name = "button_exit_auth";
            this.button_exit_auth.Size = new System.Drawing.Size(25, 25);
            this.button_exit_auth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_exit_auth.TabIndex = 1;
            this.button_exit_auth.TabStop = false;
            this.button_exit_auth.Click += new System.EventHandler(this.button_exit_auth_Click);
            // 
            // label_title_auth
            // 
            this.label_title_auth.AutoSize = true;
            this.label_title_auth.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_auth.ForeColor = System.Drawing.Color.White;
            this.label_title_auth.Location = new System.Drawing.Point(20, 7);
            this.label_title_auth.Name = "label_title_auth";
            this.label_title_auth.Size = new System.Drawing.Size(193, 34);
            this.label_title_auth.TabIndex = 0;
            this.label_title_auth.Text = "Money Manager";
            // 
            // panel_connexion_auth
            // 
            this.panel_connexion_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.panel_connexion_auth.Controls.Add(this.link_to_panel_inscription_auth);
            this.panel_connexion_auth.Controls.Add(this.label1);
            this.panel_connexion_auth.Controls.Add(this.button_connexion_auth);
            this.panel_connexion_auth.Controls.Add(this.label_password_text);
            this.panel_connexion_auth.Controls.Add(this.text_password_connexion_auth);
            this.panel_connexion_auth.Controls.Add(this.label_email_text);
            this.panel_connexion_auth.Controls.Add(this.text_pseudo_connexion_auth);
            this.panel_connexion_auth.Controls.Add(this.label_connexion_text);
            this.panel_connexion_auth.Location = new System.Drawing.Point(195, 130);
            this.panel_connexion_auth.Name = "panel_connexion_auth";
            this.panel_connexion_auth.Size = new System.Drawing.Size(481, 408);
            this.panel_connexion_auth.TabIndex = 2;
            // 
            // link_to_panel_inscription_auth
            // 
            this.link_to_panel_inscription_auth.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.link_to_panel_inscription_auth.AutoSize = true;
            this.link_to_panel_inscription_auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_to_panel_inscription_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_to_panel_inscription_auth.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(158)))));
            this.link_to_panel_inscription_auth.Location = new System.Drawing.Point(261, 375);
            this.link_to_panel_inscription_auth.Name = "link_to_panel_inscription_auth";
            this.link_to_panel_inscription_auth.Size = new System.Drawing.Size(79, 16);
            this.link_to_panel_inscription_auth.TabIndex = 7;
            this.link_to_panel_inscription_auth.TabStop = true;
            this.link_to_panel_inscription_auth.Text = "Créez-en un";
            this.link_to_panel_inscription_auth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_to_panel_inscription_auth_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pas de compte ?";
            // 
            // button_connexion_auth
            // 
            this.button_connexion_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.button_connexion_auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connexion_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connexion_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.button_connexion_auth.Location = new System.Drawing.Point(134, 295);
            this.button_connexion_auth.Name = "button_connexion_auth";
            this.button_connexion_auth.Size = new System.Drawing.Size(222, 58);
            this.button_connexion_auth.TabIndex = 5;
            this.button_connexion_auth.Text = "Se connecter";
            this.button_connexion_auth.UseVisualStyleBackColor = false;
            this.button_connexion_auth.Click += new System.EventHandler(this.button_connexion_auth_Click);
            // 
            // label_password_text
            // 
            this.label_password_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password_text.AutoSize = true;
            this.label_password_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label_password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password_text.ForeColor = System.Drawing.Color.White;
            this.label_password_text.Location = new System.Drawing.Point(73, 196);
            this.label_password_text.Name = "label_password_text";
            this.label_password_text.Size = new System.Drawing.Size(117, 20);
            this.label_password_text.TabIndex = 4;
            this.label_password_text.Text = "Mot de passe";
            // 
            // text_password_connexion_auth
            // 
            this.text_password_connexion_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.text_password_connexion_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password_connexion_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.text_password_connexion_auth.Location = new System.Drawing.Point(73, 219);
            this.text_password_connexion_auth.Name = "text_password_connexion_auth";
            this.text_password_connexion_auth.PasswordChar = '*';
            this.text_password_connexion_auth.Size = new System.Drawing.Size(336, 24);
            this.text_password_connexion_auth.TabIndex = 3;
            // 
            // label_email_text
            // 
            this.label_email_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_email_text.AutoSize = true;
            this.label_email_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label_email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_text.ForeColor = System.Drawing.Color.White;
            this.label_email_text.Location = new System.Drawing.Point(73, 105);
            this.label_email_text.Name = "label_email_text";
            this.label_email_text.Size = new System.Drawing.Size(69, 20);
            this.label_email_text.TabIndex = 2;
            this.label_email_text.Text = "Pseudo";
            // 
            // text_pseudo_connexion_auth
            // 
            this.text_pseudo_connexion_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.text_pseudo_connexion_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pseudo_connexion_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.text_pseudo_connexion_auth.Location = new System.Drawing.Point(73, 128);
            this.text_pseudo_connexion_auth.Name = "text_pseudo_connexion_auth";
            this.text_pseudo_connexion_auth.Size = new System.Drawing.Size(336, 24);
            this.text_pseudo_connexion_auth.TabIndex = 1;
            // 
            // label_connexion_text
            // 
            this.label_connexion_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_connexion_text.AutoSize = true;
            this.label_connexion_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label_connexion_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connexion_text.ForeColor = System.Drawing.Color.White;
            this.label_connexion_text.Location = new System.Drawing.Point(155, 35);
            this.label_connexion_text.Name = "label_connexion_text";
            this.label_connexion_text.Size = new System.Drawing.Size(170, 29);
            this.label_connexion_text.TabIndex = 0;
            this.label_connexion_text.Text = "CONNEXION";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(154, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "INSCRIPTION";
            // 
            // button_inscription_auth
            // 
            this.button_inscription_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.button_inscription_auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_inscription_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inscription_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.button_inscription_auth.Location = new System.Drawing.Point(134, 295);
            this.button_inscription_auth.Name = "button_inscription_auth";
            this.button_inscription_auth.Size = new System.Drawing.Size(222, 58);
            this.button_inscription_auth.TabIndex = 5;
            this.button_inscription_auth.Text = "S\'inscrire";
            this.button_inscription_auth.UseVisualStyleBackColor = false;
            this.button_inscription_auth.Click += new System.EventHandler(this.button_inscription_auth_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Déjà membre ?";
            // 
            // link_to_panel_connexion_auth
            // 
            this.link_to_panel_connexion_auth.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.link_to_panel_connexion_auth.AutoSize = true;
            this.link_to_panel_connexion_auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_to_panel_connexion_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_to_panel_connexion_auth.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(158)))));
            this.link_to_panel_connexion_auth.Location = new System.Drawing.Point(239, 375);
            this.link_to_panel_connexion_auth.Name = "link_to_panel_connexion_auth";
            this.link_to_panel_connexion_auth.Size = new System.Drawing.Size(120, 16);
            this.link_to_panel_connexion_auth.TabIndex = 7;
            this.link_to_panel_connexion_auth.TabStop = true;
            this.link_to_panel_connexion_auth.Text = "Connectez-vous ici";
            this.link_to_panel_connexion_auth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_to_panel_connexion_auth_LinkClicked);
            // 
            // panel_inscription_auth
            // 
            this.panel_inscription_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.panel_inscription_auth.Controls.Add(this.label3);
            this.panel_inscription_auth.Controls.Add(this.text_password_inscription_auth);
            this.panel_inscription_auth.Controls.Add(this.label4);
            this.panel_inscription_auth.Controls.Add(this.text_pseudo_inscription_auth);
            this.panel_inscription_auth.Controls.Add(this.link_to_panel_connexion_auth);
            this.panel_inscription_auth.Controls.Add(this.label2);
            this.panel_inscription_auth.Controls.Add(this.button_inscription_auth);
            this.panel_inscription_auth.Controls.Add(this.label5);
            this.panel_inscription_auth.Location = new System.Drawing.Point(195, 130);
            this.panel_inscription_auth.Name = "panel_inscription_auth";
            this.panel_inscription_auth.Size = new System.Drawing.Size(481, 408);
            this.panel_inscription_auth.TabIndex = 8;
            this.panel_inscription_auth.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mot de passe";
            // 
            // text_password_inscription_auth
            // 
            this.text_password_inscription_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.text_password_inscription_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password_inscription_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.text_password_inscription_auth.Location = new System.Drawing.Point(73, 219);
            this.text_password_inscription_auth.Name = "text_password_inscription_auth";
            this.text_password_inscription_auth.PasswordChar = '*';
            this.text_password_inscription_auth.Size = new System.Drawing.Size(336, 24);
            this.text_password_inscription_auth.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pseudo";
            // 
            // text_pseudo_inscription_auth
            // 
            this.text_pseudo_inscription_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.text_pseudo_inscription_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pseudo_inscription_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.text_pseudo_inscription_auth.Location = new System.Drawing.Point(73, 128);
            this.text_pseudo_inscription_auth.Name = "text_pseudo_inscription_auth";
            this.text_pseudo_inscription_auth.Size = new System.Drawing.Size(336, 24);
            this.text_pseudo_inscription_auth.TabIndex = 8;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(this.panel_inscription_auth);
            this.Controls.Add(this.panel_connexion_auth);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Your Money";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_exit_auth)).EndInit();
            this.panel_connexion_auth.ResumeLayout(false);
            this.panel_connexion_auth.PerformLayout();
            this.panel_inscription_auth.ResumeLayout(false);
            this.panel_inscription_auth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_connexion_auth;
        private System.Windows.Forms.TextBox text_pseudo_connexion_auth;
        private System.Windows.Forms.Label label_connexion_text;
        private System.Windows.Forms.Label label_password_text;
        private System.Windows.Forms.TextBox text_password_connexion_auth;
        private System.Windows.Forms.Label label_email_text;
        private System.Windows.Forms.Button button_connexion_auth;
        private System.Windows.Forms.LinkLabel link_to_panel_inscription_auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title_auth;
        private System.Windows.Forms.PictureBox button_exit_auth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_inscription_auth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_to_panel_connexion_auth;
        private System.Windows.Forms.Panel panel_inscription_auth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_password_inscription_auth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_pseudo_inscription_auth;
    }
}


namespace gestion
{
    partial class form_gestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_gestion));
            this.strip_menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entretienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEntretiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_login = new FlatUI.FlatTextBox();
            this.label_login = new FlatUI.FlatLabel();
            this.label_mdp = new FlatUI.FlatLabel();
            this.textbox_mdp = new FlatUI.FlatTextBox();
            this.button_annuler = new FlatUI.FlatButton();
            this.button_connexion = new FlatUI.FlatButton();
            this.alert_info = new FlatUI.FlatAlertBox();
            this.strip_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // strip_menu
            // 
            this.strip_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.strip_menu.Enabled = false;
            this.strip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.personnelToolStripMenuItem,
            this.véhiculeToolStripMenuItem});
            this.strip_menu.Location = new System.Drawing.Point(0, 0);
            this.strip_menu.Name = "strip_menu";
            this.strip_menu.Size = new System.Drawing.Size(556, 24);
            this.strip_menu.TabIndex = 0;
            this.strip_menu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem2,
            this.rechercherToolStripMenuItem2});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tablesToolStripMenuItem.Text = "Service";
            this.tablesToolStripMenuItem.Click += new System.EventHandler(this.tablesToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem2
            // 
            this.gérerToolStripMenuItem2.Name = "gérerToolStripMenuItem2";
            this.gérerToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.gérerToolStripMenuItem2.Text = "Gérer";
            this.gérerToolStripMenuItem2.Click += new System.EventHandler(this.gérerToolStripMenuItem2_Click);
            // 
            // rechercherToolStripMenuItem2
            // 
            this.rechercherToolStripMenuItem2.Name = "rechercherToolStripMenuItem2";
            this.rechercherToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.rechercherToolStripMenuItem2.Text = "Rechercher";
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.personnelToolStripMenuItem.Text = "Personnel";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gérerToolStripMenuItem.Text = "Gérer";
            this.gérerToolStripMenuItem.Click += new System.EventHandler(this.gérerToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            // 
            // véhiculeToolStripMenuItem
            // 
            this.véhiculeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem1,
            this.entretienToolStripMenuItem,
            this.rechercherToolStripMenuItem1});
            this.véhiculeToolStripMenuItem.Name = "véhiculeToolStripMenuItem";
            this.véhiculeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.véhiculeToolStripMenuItem.Text = "Véhicule";
            // 
            // gérerToolStripMenuItem1
            // 
            this.gérerToolStripMenuItem1.Name = "gérerToolStripMenuItem1";
            this.gérerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.gérerToolStripMenuItem1.Text = "Gérer";
            this.gérerToolStripMenuItem1.Click += new System.EventHandler(this.gérerToolStripMenuItem1_Click);
            // 
            // entretienToolStripMenuItem
            // 
            this.entretienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeEntretiensToolStripMenuItem});
            this.entretienToolStripMenuItem.Name = "entretienToolStripMenuItem";
            this.entretienToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entretienToolStripMenuItem.Text = "Entretien";
            // 
            // listeEntretiensToolStripMenuItem
            // 
            this.listeEntretiensToolStripMenuItem.Name = "listeEntretiensToolStripMenuItem";
            this.listeEntretiensToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.listeEntretiensToolStripMenuItem.Text = "Liste Entretiens";
            this.listeEntretiensToolStripMenuItem.Click += new System.EventHandler(this.listeEntretiensToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem1
            // 
            this.rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            this.rechercherToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rechercherToolStripMenuItem1.Text = "Rechercher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.flatLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flatLabel1.Location = new System.Drawing.Point(170, 27);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(225, 37);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Gestionnaire MSL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_connexion);
            this.groupBox1.Controls.Add(this.button_annuler);
            this.groupBox1.Controls.Add(this.label_mdp);
            this.groupBox1.Controls.Add(this.textbox_mdp);
            this.groupBox1.Controls.Add(this.label_login);
            this.groupBox1.Controls.Add(this.textbox_login);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // textbox_login
            // 
            this.textbox_login.BackColor = System.Drawing.Color.Transparent;
            this.textbox_login.FocusOnHover = false;
            this.textbox_login.Location = new System.Drawing.Point(112, 19);
            this.textbox_login.MaxLength = 32767;
            this.textbox_login.Multiline = false;
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.ReadOnly = false;
            this.textbox_login.Size = new System.Drawing.Size(196, 29);
            this.textbox_login.TabIndex = 0;
            this.textbox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_login.UseSystemPasswordChar = false;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(55, 24);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(51, 17);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Login : ";
            // 
            // label_mdp
            // 
            this.label_mdp.AutoSize = true;
            this.label_mdp.BackColor = System.Drawing.Color.Transparent;
            this.label_mdp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mdp.ForeColor = System.Drawing.Color.Black;
            this.label_mdp.Location = new System.Drawing.Point(6, 60);
            this.label_mdp.Name = "label_mdp";
            this.label_mdp.Size = new System.Drawing.Size(100, 17);
            this.label_mdp.TabIndex = 3;
            this.label_mdp.Text = "Mot de passe : ";
            // 
            // textbox_mdp
            // 
            this.textbox_mdp.BackColor = System.Drawing.Color.Transparent;
            this.textbox_mdp.FocusOnHover = false;
            this.textbox_mdp.Location = new System.Drawing.Point(112, 54);
            this.textbox_mdp.MaxLength = 32767;
            this.textbox_mdp.Multiline = false;
            this.textbox_mdp.Name = "textbox_mdp";
            this.textbox_mdp.ReadOnly = false;
            this.textbox_mdp.Size = new System.Drawing.Size(196, 29);
            this.textbox_mdp.TabIndex = 2;
            this.textbox_mdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_mdp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_mdp.UseSystemPasswordChar = true;
            // 
            // button_annuler
            // 
            this.button_annuler.BackColor = System.Drawing.Color.Transparent;
            this.button_annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_annuler.Location = new System.Drawing.Point(420, 51);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Rounded = false;
            this.button_annuler.Size = new System.Drawing.Size(106, 32);
            this.button_annuler.TabIndex = 4;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // button_connexion
            // 
            this.button_connexion.BackColor = System.Drawing.Color.Transparent;
            this.button_connexion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_connexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connexion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_connexion.Location = new System.Drawing.Point(420, 13);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Rounded = false;
            this.button_connexion.Size = new System.Drawing.Size(106, 32);
            this.button_connexion.TabIndex = 5;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // alert_info
            // 
            this.alert_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.alert_info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alert_info.Enabled = false;
            this.alert_info.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alert_info.kind = FlatUI.FlatAlertBox._Kind.Info;
            this.alert_info.Location = new System.Drawing.Point(0, 374);
            this.alert_info.Name = "alert_info";
            this.alert_info.Size = new System.Drawing.Size(600, 42);
            this.alert_info.TabIndex = 4;
            this.alert_info.Text = "Une connexion est nécessaire afin de pouvoir utiliser le programme";
            // 
            // form_gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 415);
            this.Controls.Add(this.alert_info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.strip_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.strip_menu;
            this.MaximizeBox = false;
            this.Name = "form_gestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSL - Gestion";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.form_gestion_Load);
            this.strip_menu.ResumeLayout(false);
            this.strip_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip strip_menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem véhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem entretienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeEntretiensToolStripMenuItem;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FlatUI.FlatButton button_connexion;
        private FlatUI.FlatButton button_annuler;
        private FlatUI.FlatLabel label_mdp;
        private FlatUI.FlatTextBox textbox_mdp;
        private FlatUI.FlatLabel label_login;
        private FlatUI.FlatTextBox textbox_login;
        private FlatUI.FlatAlertBox alert_info;
    }
}


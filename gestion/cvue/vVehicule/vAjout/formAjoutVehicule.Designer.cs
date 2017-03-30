namespace gestion.cvue.vVehicule.vAjout
{
    partial class formAjoutVehicule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAjoutVehicule));
            this.label_ajout_immatriculation = new System.Windows.Forms.Label();
            this.label_ajout_marque = new System.Windows.Forms.Label();
            this.label_ajout_annee = new System.Windows.Forms.Label();
            this.label_ajout_modele = new System.Windows.Forms.Label();
            this.label_ajout_nbKmCompteur = new System.Windows.Forms.Label();
            this.label_ajout_motorisation = new System.Windows.Forms.Label();
            this._combo_ajout_marque = new System.Windows.Forms.ComboBox();
            this._combo_ajout_modele = new System.Windows.Forms.ComboBox();
            this._combo_ajout_annee = new System.Windows.Forms.ComboBox();
            this.t_ajout_checkLength_imma = new System.Windows.Forms.Timer(this.components);
            this.label_ajout_dateachat = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this._ajout_combo_motorisation = new FlatUI.FlatComboBox();
            this._ajout_numeric_kmcompteur = new FlatUI.FlatNumeric();
            this.arlette_ajout_info = new FlatUI.FlatAlertBox();
            this._ajout_imma = new FlatUI.FlatTextBox();
            this._ajout_Annuler = new FlatUI.FlatButton();
            this._affectation_affecter = new FlatUI.FlatButton();
            this.SuspendLayout();
            // 
            // label_ajout_immatriculation
            // 
            this.label_ajout_immatriculation.AutoSize = true;
            this.label_ajout_immatriculation.Location = new System.Drawing.Point(55, 85);
            this.label_ajout_immatriculation.Name = "label_ajout_immatriculation";
            this.label_ajout_immatriculation.Size = new System.Drawing.Size(83, 13);
            this.label_ajout_immatriculation.TabIndex = 63;
            this.label_ajout_immatriculation.Text = "Immatriculation :";
            // 
            // label_ajout_marque
            // 
            this.label_ajout_marque.AutoSize = true;
            this.label_ajout_marque.Location = new System.Drawing.Point(55, 115);
            this.label_ajout_marque.Name = "label_ajout_marque";
            this.label_ajout_marque.Size = new System.Drawing.Size(49, 13);
            this.label_ajout_marque.TabIndex = 57;
            this.label_ajout_marque.Text = "Marque :";
            // 
            // label_ajout_annee
            // 
            this.label_ajout_annee.AutoSize = true;
            this.label_ajout_annee.Location = new System.Drawing.Point(55, 169);
            this.label_ajout_annee.Name = "label_ajout_annee";
            this.label_ajout_annee.Size = new System.Drawing.Size(44, 13);
            this.label_ajout_annee.TabIndex = 56;
            this.label_ajout_annee.Text = "Année :";
            // 
            // label_ajout_modele
            // 
            this.label_ajout_modele.AutoSize = true;
            this.label_ajout_modele.Location = new System.Drawing.Point(55, 142);
            this.label_ajout_modele.Name = "label_ajout_modele";
            this.label_ajout_modele.Size = new System.Drawing.Size(48, 13);
            this.label_ajout_modele.TabIndex = 55;
            this.label_ajout_modele.Text = "Modele :";
            // 
            // label_ajout_nbKmCompteur
            // 
            this.label_ajout_nbKmCompteur.AutoSize = true;
            this.label_ajout_nbKmCompteur.Location = new System.Drawing.Point(55, 197);
            this.label_ajout_nbKmCompteur.Name = "label_ajout_nbKmCompteur";
            this.label_ajout_nbKmCompteur.Size = new System.Drawing.Size(76, 13);
            this.label_ajout_nbKmCompteur.TabIndex = 65;
            this.label_ajout_nbKmCompteur.Text = "Km Compteur :";
            // 
            // label_ajout_motorisation
            // 
            this.label_ajout_motorisation.AutoSize = true;
            this.label_ajout_motorisation.Location = new System.Drawing.Point(55, 228);
            this.label_ajout_motorisation.Name = "label_ajout_motorisation";
            this.label_ajout_motorisation.Size = new System.Drawing.Size(70, 13);
            this.label_ajout_motorisation.TabIndex = 67;
            this.label_ajout_motorisation.Text = "Motorisation :";
            // 
            // _combo_ajout_marque
            // 
            this._combo_ajout_marque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo_ajout_marque.Enabled = false;
            this._combo_ajout_marque.FormattingEnabled = true;
            this._combo_ajout_marque.Location = new System.Drawing.Point(162, 112);
            this._combo_ajout_marque.Name = "_combo_ajout_marque";
            this._combo_ajout_marque.Size = new System.Drawing.Size(121, 21);
            this._combo_ajout_marque.TabIndex = 74;
            this._combo_ajout_marque.SelectedIndexChanged += new System.EventHandler(this._combo_ajout_marque_SelectedIndexChanged);
            // 
            // _combo_ajout_modele
            // 
            this._combo_ajout_modele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo_ajout_modele.Enabled = false;
            this._combo_ajout_modele.FormattingEnabled = true;
            this._combo_ajout_modele.Location = new System.Drawing.Point(162, 139);
            this._combo_ajout_modele.Name = "_combo_ajout_modele";
            this._combo_ajout_modele.Size = new System.Drawing.Size(121, 21);
            this._combo_ajout_modele.TabIndex = 73;
            this._combo_ajout_modele.SelectedIndexChanged += new System.EventHandler(this._combo_ajout_modele_SelectedIndexChanged);
            // 
            // _combo_ajout_annee
            // 
            this._combo_ajout_annee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo_ajout_annee.Enabled = false;
            this._combo_ajout_annee.FormattingEnabled = true;
            this._combo_ajout_annee.Location = new System.Drawing.Point(162, 166);
            this._combo_ajout_annee.Name = "_combo_ajout_annee";
            this._combo_ajout_annee.Size = new System.Drawing.Size(121, 21);
            this._combo_ajout_annee.TabIndex = 75;
            // 
            // t_ajout_checkLength_imma
            // 
            this.t_ajout_checkLength_imma.Enabled = true;
            this.t_ajout_checkLength_imma.Interval = 250;
            this.t_ajout_checkLength_imma.Tick += new System.EventHandler(this.t_ajout_checkLength_imma_Tick);
            // 
            // label_ajout_dateachat
            // 
            this.label_ajout_dateachat.AutoSize = true;
            this.label_ajout_dateachat.Location = new System.Drawing.Point(55, 267);
            this.label_ajout_dateachat.Name = "label_ajout_dateachat";
            this.label_ajout_dateachat.Size = new System.Drawing.Size(74, 13);
            this.label_ajout_dateachat.TabIndex = 79;
            this.label_ajout_dateachat.Text = "Date d\'achat :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 80;
            // 
            // _ajout_combo_motorisation
            // 
            this._ajout_combo_motorisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this._ajout_combo_motorisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ajout_combo_motorisation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._ajout_combo_motorisation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ajout_combo_motorisation.Font = new System.Drawing.Font("Segoe UI", 8F);
            this._ajout_combo_motorisation.ForeColor = System.Drawing.Color.White;
            this._ajout_combo_motorisation.FormattingEnabled = true;
            this._ajout_combo_motorisation.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._ajout_combo_motorisation.ItemHeight = 18;
            this._ajout_combo_motorisation.Items.AddRange(new object[] {
            "SP-95",
            "SP-95-E10",
            "SP-98",
            "Flex Fuel",
            "Diesel",
            "Electrique"});
            this._ajout_combo_motorisation.Location = new System.Drawing.Point(162, 225);
            this._ajout_combo_motorisation.Name = "_ajout_combo_motorisation";
            this._ajout_combo_motorisation.Size = new System.Drawing.Size(121, 24);
            this._ajout_combo_motorisation.State1 = FlatUI.MouseState.None;
            this._ajout_combo_motorisation.State2 = FlatUI.MouseState.None;
            this._ajout_combo_motorisation.State3 = FlatUI.MouseState.None;
            this._ajout_combo_motorisation.TabIndex = 78;
            // 
            // _ajout_numeric_kmcompteur
            // 
            this._ajout_numeric_kmcompteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this._ajout_numeric_kmcompteur.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this._ajout_numeric_kmcompteur.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._ajout_numeric_kmcompteur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._ajout_numeric_kmcompteur.ForeColor = System.Drawing.Color.White;
            this._ajout_numeric_kmcompteur.Location = new System.Drawing.Point(162, 191);
            this._ajout_numeric_kmcompteur.Maximum = ((long)(9999999));
            this._ajout_numeric_kmcompteur.Minimum = ((long)(0));
            this._ajout_numeric_kmcompteur.Name = "_ajout_numeric_kmcompteur";
            this._ajout_numeric_kmcompteur.Size = new System.Drawing.Size(121, 30);
            this._ajout_numeric_kmcompteur.TabIndex = 77;
            this._ajout_numeric_kmcompteur.Text = "flatNumeric1";
            this._ajout_numeric_kmcompteur.Value = ((long)(0));
            // 
            // arlette_ajout_info
            // 
            this.arlette_ajout_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.arlette_ajout_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.arlette_ajout_info.Enabled = false;
            this.arlette_ajout_info.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.arlette_ajout_info.kind = FlatUI.FlatAlertBox._Kind.Info;
            this.arlette_ajout_info.Location = new System.Drawing.Point(10, 12);
            this.arlette_ajout_info.Name = "arlette_ajout_info";
            this.arlette_ajout_info.Size = new System.Drawing.Size(336, 42);
            this.arlette_ajout_info.TabIndex = 76;
            this.arlette_ajout_info.Text = "Vous pouvez ici, ajouter un véhicule";
            this.arlette_ajout_info.Visible = false;
            // 
            // _ajout_imma
            // 
            this._ajout_imma.BackColor = System.Drawing.Color.Transparent;
            this._ajout_imma.FocusOnHover = false;
            this._ajout_imma.Location = new System.Drawing.Point(162, 77);
            this._ajout_imma.MaxLength = 8;
            this._ajout_imma.Multiline = false;
            this._ajout_imma.Name = "_ajout_imma";
            this._ajout_imma.ReadOnly = false;
            this._ajout_imma.Size = new System.Drawing.Size(121, 29);
            this._ajout_imma.TabIndex = 64;
            this._ajout_imma.Text = "AB123ABC";
            this._ajout_imma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this._ajout_imma.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._ajout_imma.UseSystemPasswordChar = false;
            // 
            // _ajout_Annuler
            // 
            this._ajout_Annuler.BackColor = System.Drawing.Color.Transparent;
            this._ajout_Annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._ajout_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ajout_Annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._ajout_Annuler.Location = new System.Drawing.Point(240, 305);
            this._ajout_Annuler.Name = "_ajout_Annuler";
            this._ajout_Annuler.Rounded = false;
            this._ajout_Annuler.Size = new System.Drawing.Size(106, 32);
            this._ajout_Annuler.TabIndex = 53;
            this._ajout_Annuler.Text = "Annuler";
            this._ajout_Annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this._ajout_Annuler.Click += new System.EventHandler(this._ajout_Annuler_Click);
            // 
            // _affectation_affecter
            // 
            this._affectation_affecter.BackColor = System.Drawing.Color.Transparent;
            this._affectation_affecter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._affectation_affecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this._affectation_affecter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._affectation_affecter.Location = new System.Drawing.Point(12, 305);
            this._affectation_affecter.Name = "_affectation_affecter";
            this._affectation_affecter.Rounded = false;
            this._affectation_affecter.Size = new System.Drawing.Size(106, 32);
            this._affectation_affecter.TabIndex = 52;
            this._affectation_affecter.Text = "Ajouter";
            this._affectation_affecter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this._affectation_affecter.Click += new System.EventHandler(this._affectation_affecter_Click);
            // 
            // formAjoutVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 349);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_ajout_dateachat);
            this.Controls.Add(this._ajout_combo_motorisation);
            this.Controls.Add(this._ajout_numeric_kmcompteur);
            this.Controls.Add(this.arlette_ajout_info);
            this.Controls.Add(this._combo_ajout_annee);
            this.Controls.Add(this._combo_ajout_marque);
            this.Controls.Add(this._combo_ajout_modele);
            this.Controls.Add(this.label_ajout_motorisation);
            this.Controls.Add(this.label_ajout_nbKmCompteur);
            this.Controls.Add(this._ajout_imma);
            this.Controls.Add(this.label_ajout_immatriculation);
            this.Controls.Add(this.label_ajout_marque);
            this.Controls.Add(this.label_ajout_annee);
            this.Controls.Add(this.label_ajout_modele);
            this.Controls.Add(this._ajout_Annuler);
            this.Controls.Add(this._affectation_affecter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAjoutVehicule";
            this.Text = "Ajouter un véhicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatTextBox _ajout_imma;
        private System.Windows.Forms.Label label_ajout_immatriculation;
        private System.Windows.Forms.Label label_ajout_marque;
        private System.Windows.Forms.Label label_ajout_annee;
        private System.Windows.Forms.Label label_ajout_modele;
        private FlatUI.FlatButton _ajout_Annuler;
        private FlatUI.FlatButton _affectation_affecter;
        private System.Windows.Forms.Label label_ajout_nbKmCompteur;
        private System.Windows.Forms.Label label_ajout_motorisation;
        private System.Windows.Forms.ComboBox _combo_ajout_marque;
        private System.Windows.Forms.ComboBox _combo_ajout_modele;
        private System.Windows.Forms.ComboBox _combo_ajout_annee;
        private System.Windows.Forms.Timer t_ajout_checkLength_imma;
        private FlatUI.FlatAlertBox arlette_ajout_info;
        private FlatUI.FlatNumeric _ajout_numeric_kmcompteur;
        private FlatUI.FlatComboBox _ajout_combo_motorisation;
        private System.Windows.Forms.Label label_ajout_dateachat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
namespace gestion.cvue.vVehicule
{
    partial class formVehiculeMarque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVehiculeMarque));
            this.dgv_vehicule = new System.Windows.Forms.DataGridView();
            this.button_vehicule_annuler = new FlatUI.FlatButton();
            this.infobar_vehicule = new FlatUI.FlatStatusBar();
            this.button_vehicule_modifier = new FlatUI.FlatButton();
            this.id_vehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vehicule
            // 
            this.dgv_vehicule.AllowUserToAddRows = false;
            this.dgv_vehicule.AllowUserToDeleteRows = false;
            this.dgv_vehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vehicule,
            this.modele,
            this.marque,
            this.nom_annee});
            this.dgv_vehicule.Location = new System.Drawing.Point(12, 12);
            this.dgv_vehicule.Name = "dgv_vehicule";
            this.dgv_vehicule.ReadOnly = true;
            this.dgv_vehicule.RowHeadersVisible = false;
            this.dgv_vehicule.Size = new System.Drawing.Size(631, 264);
            this.dgv_vehicule.TabIndex = 0;
            this.dgv_vehicule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehicule_CellContentClick);
            // 
            // button_vehicule_annuler
            // 
            this.button_vehicule_annuler.BackColor = System.Drawing.Color.Transparent;
            this.button_vehicule_annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_vehicule_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vehicule_annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_vehicule_annuler.Location = new System.Drawing.Point(531, 282);
            this.button_vehicule_annuler.Name = "button_vehicule_annuler";
            this.button_vehicule_annuler.Rounded = false;
            this.button_vehicule_annuler.Size = new System.Drawing.Size(112, 43);
            this.button_vehicule_annuler.TabIndex = 12;
            this.button_vehicule_annuler.Text = "Annuler";
            this.button_vehicule_annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_vehicule_annuler.Click += new System.EventHandler(this.button_vehicule_annuler_Click);
            // 
            // infobar_vehicule
            // 
            this.infobar_vehicule.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.infobar_vehicule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infobar_vehicule.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.infobar_vehicule.ForeColor = System.Drawing.Color.White;
            this.infobar_vehicule.Location = new System.Drawing.Point(0, 378);
            this.infobar_vehicule.Name = "infobar_vehicule";
            this.infobar_vehicule.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.infobar_vehicule.ShowTimeDate = false;
            this.infobar_vehicule.Size = new System.Drawing.Size(655, 23);
            this.infobar_vehicule.TabIndex = 11;
            this.infobar_vehicule.Text = "Véhicule : ";
            this.infobar_vehicule.TextColor = System.Drawing.Color.White;
            // 
            // button_vehicule_modifier
            // 
            this.button_vehicule_modifier.BackColor = System.Drawing.Color.Transparent;
            this.button_vehicule_modifier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_vehicule_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vehicule_modifier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_vehicule_modifier.Location = new System.Drawing.Point(12, 282);
            this.button_vehicule_modifier.Name = "button_vehicule_modifier";
            this.button_vehicule_modifier.Rounded = false;
            this.button_vehicule_modifier.Size = new System.Drawing.Size(112, 43);
            this.button_vehicule_modifier.TabIndex = 9;
            this.button_vehicule_modifier.Text = "Modifier";
            this.button_vehicule_modifier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_vehicule_modifier.Click += new System.EventHandler(this.button_vehicule_modifier_Click);
            // 
            // id_vehicule
            // 
            this.id_vehicule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_vehicule.HeaderText = "Id vehicule";
            this.id_vehicule.Name = "id_vehicule";
            this.id_vehicule.ReadOnly = true;
            // 
            // modele
            // 
            this.modele.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modele.HeaderText = "Modèle";
            this.modele.Name = "modele";
            this.modele.ReadOnly = true;
            // 
            // marque
            // 
            this.marque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marque.HeaderText = "Marque";
            this.marque.Name = "marque";
            this.marque.ReadOnly = true;
            // 
            // nom_annee
            // 
            this.nom_annee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_annee.HeaderText = "Année";
            this.nom_annee.Name = "nom_annee";
            this.nom_annee.ReadOnly = true;
            // 
            // formVehiculeMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 401);
            this.Controls.Add(this.button_vehicule_annuler);
            this.Controls.Add(this.infobar_vehicule);
            this.Controls.Add(this.button_vehicule_modifier);
            this.Controls.Add(this.dgv_vehicule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formVehiculeMarque";
            this.Text = "Gestion - MSL - Véhicule - Marque";
            this.Load += new System.EventHandler(this.formVehiculeMarque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vehicule;
        private FlatUI.FlatButton button_vehicule_modifier;
        private FlatUI.FlatStatusBar infobar_vehicule;
        private FlatUI.FlatButton button_vehicule_annuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn modele;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_annee;
    }
}
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
            this.id_vehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this._combo_vehicule_affect_salarie = new FlatUI.FlatComboBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this._combo_vehicule_affect_service = new FlatUI.FlatComboBox();
            this.button_vehicule_affect = new FlatUI.FlatButton();
            this.button_vehicule_annuler = new FlatUI.FlatButton();
            this.infobar_vehicule = new FlatUI.FlatStatusBar();
            this.button_vehicule_modifier = new FlatUI.FlatButton();
            this.button_vehicule_ajouter = new FlatUI.FlatButton();
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
            this.imma,
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
            // id_vehicule
            // 
            this.id_vehicule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_vehicule.HeaderText = "Id vehicule";
            this.id_vehicule.Name = "id_vehicule";
            this.id_vehicule.ReadOnly = true;
            // 
            // imma
            // 
            this.imma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imma.HeaderText = "Immatriculation";
            this.imma.Name = "imma";
            this.imma.ReadOnly = true;
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
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatLabel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flatLabel2.Location = new System.Drawing.Point(248, 315);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(61, 15);
            this.flatLabel2.TabIndex = 17;
            this.flatLabel2.Text = "Salarié(e) :";
            // 
            // _combo_vehicule_affect_salarie
            // 
            this._combo_vehicule_affect_salarie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this._combo_vehicule_affect_salarie.Cursor = System.Windows.Forms.Cursors.Hand;
            this._combo_vehicule_affect_salarie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._combo_vehicule_affect_salarie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo_vehicule_affect_salarie.Font = new System.Drawing.Font("Segoe UI", 8F);
            this._combo_vehicule_affect_salarie.ForeColor = System.Drawing.Color.White;
            this._combo_vehicule_affect_salarie.FormattingEnabled = true;
            this._combo_vehicule_affect_salarie.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._combo_vehicule_affect_salarie.ItemHeight = 18;
            this._combo_vehicule_affect_salarie.Location = new System.Drawing.Point(315, 313);
            this._combo_vehicule_affect_salarie.Name = "_combo_vehicule_affect_salarie";
            this._combo_vehicule_affect_salarie.Size = new System.Drawing.Size(210, 24);
            this._combo_vehicule_affect_salarie.State1 = FlatUI.MouseState.None;
            this._combo_vehicule_affect_salarie.State2 = FlatUI.MouseState.None;
            this._combo_vehicule_affect_salarie.State3 = FlatUI.MouseState.None;
            this._combo_vehicule_affect_salarie.TabIndex = 16;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatLabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flatLabel1.Location = new System.Drawing.Point(248, 285);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(50, 15);
            this.flatLabel1.TabIndex = 15;
            this.flatLabel1.Text = "Service :";
            // 
            // _combo_vehicule_affect_service
            // 
            this._combo_vehicule_affect_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this._combo_vehicule_affect_service.Cursor = System.Windows.Forms.Cursors.Hand;
            this._combo_vehicule_affect_service.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._combo_vehicule_affect_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo_vehicule_affect_service.Font = new System.Drawing.Font("Segoe UI", 8F);
            this._combo_vehicule_affect_service.ForeColor = System.Drawing.Color.White;
            this._combo_vehicule_affect_service.FormattingEnabled = true;
            this._combo_vehicule_affect_service.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._combo_vehicule_affect_service.ItemHeight = 18;
            this._combo_vehicule_affect_service.Location = new System.Drawing.Point(315, 283);
            this._combo_vehicule_affect_service.Name = "_combo_vehicule_affect_service";
            this._combo_vehicule_affect_service.Size = new System.Drawing.Size(210, 24);
            this._combo_vehicule_affect_service.State1 = FlatUI.MouseState.None;
            this._combo_vehicule_affect_service.State2 = FlatUI.MouseState.None;
            this._combo_vehicule_affect_service.State3 = FlatUI.MouseState.None;
            this._combo_vehicule_affect_service.TabIndex = 14;
            this._combo_vehicule_affect_service.SelectedIndexChanged += new System.EventHandler(this._combo_vehicule_affect_service_SelectedIndexChanged);
            // 
            // button_vehicule_affect
            // 
            this.button_vehicule_affect.BackColor = System.Drawing.Color.Transparent;
            this.button_vehicule_affect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_vehicule_affect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vehicule_affect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_vehicule_affect.Location = new System.Drawing.Point(130, 282);
            this.button_vehicule_affect.Name = "button_vehicule_affect";
            this.button_vehicule_affect.Rounded = false;
            this.button_vehicule_affect.Size = new System.Drawing.Size(112, 43);
            this.button_vehicule_affect.TabIndex = 13;
            this.button_vehicule_affect.Text = "Affecter";
            this.button_vehicule_affect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_vehicule_affect.Click += new System.EventHandler(this.button_vehicule_affect_Click);
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
            this.infobar_vehicule.Location = new System.Drawing.Point(0, 383);
            this.infobar_vehicule.Name = "infobar_vehicule";
            this.infobar_vehicule.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.infobar_vehicule.ShowTimeDate = false;
            this.infobar_vehicule.Size = new System.Drawing.Size(662, 23);
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
            // button_vehicule_ajouter
            // 
            this.button_vehicule_ajouter.BackColor = System.Drawing.Color.Transparent;
            this.button_vehicule_ajouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_vehicule_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vehicule_ajouter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_vehicule_ajouter.Location = new System.Drawing.Point(12, 331);
            this.button_vehicule_ajouter.Name = "button_vehicule_ajouter";
            this.button_vehicule_ajouter.Rounded = false;
            this.button_vehicule_ajouter.Size = new System.Drawing.Size(112, 43);
            this.button_vehicule_ajouter.TabIndex = 18;
            this.button_vehicule_ajouter.Text = "Ajouter";
            this.button_vehicule_ajouter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_vehicule_ajouter.Click += new System.EventHandler(this.button_vehicule_ajouter_Click);
            // 
            // formVehiculeMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 406);
            this.Controls.Add(this.button_vehicule_ajouter);
            this.Controls.Add(this.flatLabel2);
            this.Controls.Add(this._combo_vehicule_affect_salarie);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this._combo_vehicule_affect_service);
            this.Controls.Add(this.button_vehicule_affect);
            this.Controls.Add(this.button_vehicule_annuler);
            this.Controls.Add(this.infobar_vehicule);
            this.Controls.Add(this.button_vehicule_modifier);
            this.Controls.Add(this.dgv_vehicule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formVehiculeMarque";
            this.Text = " Gestion véhicule";
            this.Load += new System.EventHandler(this.formVehiculeMarque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vehicule;
        private FlatUI.FlatButton button_vehicule_modifier;
        private FlatUI.FlatStatusBar infobar_vehicule;
        private FlatUI.FlatButton button_vehicule_annuler;
        private FlatUI.FlatButton button_vehicule_affect;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn imma;
        private System.Windows.Forms.DataGridViewTextBoxColumn modele;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_annee;
        private FlatUI.FlatComboBox _combo_vehicule_affect_service;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatComboBox _combo_vehicule_affect_salarie;
        private FlatUI.FlatButton button_vehicule_ajouter;
    }
}
namespace gestion.cvue.vPersonnel
{
    partial class formPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPersonnel));
            this.dgv_personnel = new System.Windows.Forms.DataGridView();
            this.salarie_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarie_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarie_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarie_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarie_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_personnel_vue_ajouter = new FlatUI.FlatButton();
            this.button_personnel_delete = new FlatUI.FlatButton();
            this.button_personnel_modify = new FlatUI.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_personnel
            // 
            this.dgv_personnel.AllowUserToAddRows = false;
            this.dgv_personnel.AllowUserToDeleteRows = false;
            this.dgv_personnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salarie_id,
            this.salarie_nom,
            this.salarie_prenom,
            this.salarie_service,
            this.salarie_mail});
            this.dgv_personnel.Location = new System.Drawing.Point(12, 12);
            this.dgv_personnel.Name = "dgv_personnel";
            this.dgv_personnel.ReadOnly = true;
            this.dgv_personnel.RowHeadersVisible = false;
            this.dgv_personnel.Size = new System.Drawing.Size(553, 280);
            this.dgv_personnel.TabIndex = 4;
            this.dgv_personnel.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personnel_CellValueChanged);
            // 
            // salarie_id
            // 
            this.salarie_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salarie_id.HeaderText = "Id";
            this.salarie_id.Name = "salarie_id";
            this.salarie_id.ReadOnly = true;
            // 
            // salarie_nom
            // 
            this.salarie_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salarie_nom.HeaderText = "Nom";
            this.salarie_nom.Name = "salarie_nom";
            this.salarie_nom.ReadOnly = true;
            // 
            // salarie_prenom
            // 
            this.salarie_prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salarie_prenom.HeaderText = "Prénom";
            this.salarie_prenom.Name = "salarie_prenom";
            this.salarie_prenom.ReadOnly = true;
            // 
            // salarie_service
            // 
            this.salarie_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salarie_service.HeaderText = "Service";
            this.salarie_service.Name = "salarie_service";
            this.salarie_service.ReadOnly = true;
            // 
            // salarie_mail
            // 
            this.salarie_mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salarie_mail.HeaderText = "Mail";
            this.salarie_mail.Name = "salarie_mail";
            this.salarie_mail.ReadOnly = true;
            // 
            // button_personnel_vue_ajouter
            // 
            this.button_personnel_vue_ajouter.BackColor = System.Drawing.Color.Transparent;
            this.button_personnel_vue_ajouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_personnel_vue_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personnel_vue_ajouter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_personnel_vue_ajouter.Location = new System.Drawing.Point(459, 304);
            this.button_personnel_vue_ajouter.Name = "button_personnel_vue_ajouter";
            this.button_personnel_vue_ajouter.Rounded = false;
            this.button_personnel_vue_ajouter.Size = new System.Drawing.Size(106, 32);
            this.button_personnel_vue_ajouter.TabIndex = 10;
            this.button_personnel_vue_ajouter.Text = "Ajouter...";
            this.button_personnel_vue_ajouter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_personnel_vue_ajouter.Click += new System.EventHandler(this.Button_personnel_vue_ajouterClick);
            // 
            // button_personnel_delete
            // 
            this.button_personnel_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_personnel_delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_personnel_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personnel_delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_personnel_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_personnel_delete.Location = new System.Drawing.Point(124, 304);
            this.button_personnel_delete.Name = "button_personnel_delete";
            this.button_personnel_delete.Rounded = false;
            this.button_personnel_delete.Size = new System.Drawing.Size(106, 32);
            this.button_personnel_delete.TabIndex = 9;
            this.button_personnel_delete.Text = "Supprimer";
            this.button_personnel_delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_personnel_delete.Click += new System.EventHandler(this.Button_personnel_deleteClick);
            // 
            // button_personnel_modify
            // 
            this.button_personnel_modify.BackColor = System.Drawing.Color.Transparent;
            this.button_personnel_modify.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_personnel_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personnel_modify.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_personnel_modify.Location = new System.Drawing.Point(12, 304);
            this.button_personnel_modify.Name = "button_personnel_modify";
            this.button_personnel_modify.Rounded = false;
            this.button_personnel_modify.Size = new System.Drawing.Size(106, 32);
            this.button_personnel_modify.TabIndex = 8;
            this.button_personnel_modify.Text = "Modifier";
            this.button_personnel_modify.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_personnel_modify.Click += new System.EventHandler(this.button_personnel_modify_Click);
            // 
            // formPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 348);
            this.Controls.Add(this.button_personnel_vue_ajouter);
            this.Controls.Add(this.button_personnel_delete);
            this.Controls.Add(this.button_personnel_modify);
            this.Controls.Add(this.dgv_personnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPersonnel";
            this.Text = "Gestion - MSL - Personnel";
            this.Activated += new System.EventHandler(this.formPersonnel_Activated);
            this.Load += new System.EventHandler(this.formPersonnel_Load);
            this.Enter += new System.EventHandler(this.formPersonnel_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_personnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarie_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarie_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarie_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarie_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarie_mail;
        private FlatUI.FlatButton button_personnel_modify;
        private FlatUI.FlatButton button_personnel_delete;
        private FlatUI.FlatButton button_personnel_vue_ajouter;
    }
}
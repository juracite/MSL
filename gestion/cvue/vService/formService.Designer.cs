namespace gestion.cvue.vService
{
    partial class formService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formService));
            this.dgv_service = new System.Windows.Forms.DataGridView();
            this.dgv_type_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatButton1 = new FlatUI.FlatButton();
            this.combo_service_responsable = new FlatUI.FlatComboBox();
            this.status_bar_service = new FlatUI.FlatStatusBar();
            this.button_service_vue_ajout = new FlatUI.FlatButton();
            this.button_service_supprimer = new FlatUI.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_service
            // 
            this.dgv_service.AllowUserToAddRows = false;
            this.dgv_service.AllowUserToDeleteRows = false;
            this.dgv_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_type_service,
            this.libelle_service});
            this.dgv_service.Location = new System.Drawing.Point(12, 12);
            this.dgv_service.Name = "dgv_service";
            this.dgv_service.RowHeadersVisible = false;
            this.dgv_service.Size = new System.Drawing.Size(612, 275);
            this.dgv_service.TabIndex = 0;
            this.dgv_service.SelectionChanged += new System.EventHandler(this.dgv_service_SelectionChanged);
            // 
            // dgv_type_service
            // 
            this.dgv_type_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_type_service.HeaderText = "Type de service";
            this.dgv_type_service.Name = "dgv_type_service";
            this.dgv_type_service.ReadOnly = true;
            // 
            // libelle_service
            // 
            this.libelle_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libelle_service.HeaderText = "Nom du service";
            this.libelle_service.Name = "libelle_service";
            this.libelle_service.ReadOnly = true;
            // 
            // checker
            // 
            this.checker.Enabled = true;
            this.checker.Interval = 200;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.Teal;
            this.flatLabel1.Location = new System.Drawing.Point(81, 366);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(471, 13);
            this.flatLabel1.TabIndex = 7;
            this.flatLabel1.Text = "Changer le responsable supprimera l\'ancien de son service et ne l\'affectera pas à" +
    " un autre.";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(124, 331);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(388, 32);
            this.flatButton1.TabIndex = 6;
            this.flatButton1.Text = "Affecter ce responsable";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // combo_service_responsable
            // 
            this.combo_service_responsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.combo_service_responsable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_service_responsable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_service_responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_service_responsable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.combo_service_responsable.ForeColor = System.Drawing.Color.White;
            this.combo_service_responsable.FormattingEnabled = true;
            this.combo_service_responsable.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.combo_service_responsable.ItemHeight = 18;
            this.combo_service_responsable.Location = new System.Drawing.Point(124, 301);
            this.combo_service_responsable.Name = "combo_service_responsable";
            this.combo_service_responsable.Size = new System.Drawing.Size(388, 24);
            this.combo_service_responsable.TabIndex = 5;
            this.combo_service_responsable.Tag = "cvbhngfj";
            this.combo_service_responsable.SelectedIndexChanged += new System.EventHandler(this.combo_service_responsable_SelectedIndexChanged);
            // 
            // status_bar_service
            // 
            this.status_bar_service.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.status_bar_service.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_bar_service.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.status_bar_service.ForeColor = System.Drawing.Color.White;
            this.status_bar_service.Location = new System.Drawing.Point(0, 394);
            this.status_bar_service.Name = "status_bar_service";
            this.status_bar_service.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.status_bar_service.ShowTimeDate = false;
            this.status_bar_service.Size = new System.Drawing.Size(637, 23);
            this.status_bar_service.TabIndex = 4;
            this.status_bar_service.Text = "Responsable : ";
            this.status_bar_service.TextColor = System.Drawing.Color.White;
            // 
            // button_service_vue_ajout
            // 
            this.button_service_vue_ajout.BackColor = System.Drawing.Color.Transparent;
            this.button_service_vue_ajout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_service_vue_ajout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_service_vue_ajout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_service_vue_ajout.Location = new System.Drawing.Point(518, 293);
            this.button_service_vue_ajout.Name = "button_service_vue_ajout";
            this.button_service_vue_ajout.Rounded = false;
            this.button_service_vue_ajout.Size = new System.Drawing.Size(106, 32);
            this.button_service_vue_ajout.TabIndex = 3;
            this.button_service_vue_ajout.Text = "Ajouter...";
            this.button_service_vue_ajout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_service_vue_ajout.Click += new System.EventHandler(this.Button_service_vue_ajoutClick);
            // 
            // button_service_supprimer
            // 
            this.button_service_supprimer.BackColor = System.Drawing.Color.Transparent;
            this.button_service_supprimer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_service_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_service_supprimer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_service_supprimer.Location = new System.Drawing.Point(12, 293);
            this.button_service_supprimer.Name = "button_service_supprimer";
            this.button_service_supprimer.Rounded = false;
            this.button_service_supprimer.Size = new System.Drawing.Size(106, 32);
            this.button_service_supprimer.TabIndex = 2;
            this.button_service_supprimer.Text = "Supprimer";
            this.button_service_supprimer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // formService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 417);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.combo_service_responsable);
            this.Controls.Add(this.status_bar_service);
            this.Controls.Add(this.button_service_vue_ajout);
            this.Controls.Add(this.button_service_supprimer);
            this.Controls.Add(this.dgv_service);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formService";
            this.Text = "Gestion - MSL - Service";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_service;
        private System.Windows.Forms.Timer checker;
        private FlatUI.FlatButton button_service_supprimer;
        private FlatUI.FlatButton button_service_vue_ajout;
        private FlatUI.FlatStatusBar status_bar_service;
        private FlatUI.FlatComboBox combo_service_responsable;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_type_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle_service;
    }
}
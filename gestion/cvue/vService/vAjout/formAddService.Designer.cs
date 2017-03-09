namespace gestion.cvue.vService.vAjout
{
    partial class formAddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddService));
            this.label_service_nom = new System.Windows.Forms.Label();
            this._service_nomService = new System.Windows.Forms.TextBox();
            this.label_header_addservice = new System.Windows.Forms.Label();
            this.label_service_type = new System.Windows.Forms.Label();
            this.combo_service_type = new System.Windows.Forms.ComboBox();
            this.button_service_vue_ajout_ajouter = new FlatUI.FlatButton();
            this.button_service_vue_ajout_annuler = new FlatUI.FlatButton();
            this.SuspendLayout();
            // 
            // label_service_nom
            // 
            this.label_service_nom.AutoSize = true;
            this.label_service_nom.Location = new System.Drawing.Point(12, 45);
            this.label_service_nom.Name = "label_service_nom";
            this.label_service_nom.Size = new System.Drawing.Size(90, 13);
            this.label_service_nom.TabIndex = 0;
            this.label_service_nom.Text = "Nom du service : ";
            // 
            // _service_nomService
            // 
            this._service_nomService.Location = new System.Drawing.Point(110, 42);
            this._service_nomService.Name = "_service_nomService";
            this._service_nomService.Size = new System.Drawing.Size(166, 20);
            this._service_nomService.TabIndex = 1;
            // 
            // label_header_addservice
            // 
            this.label_header_addservice.AutoSize = true;
            this.label_header_addservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_addservice.Location = new System.Drawing.Point(61, 9);
            this.label_header_addservice.Name = "label_header_addservice";
            this.label_header_addservice.Size = new System.Drawing.Size(168, 25);
            this.label_header_addservice.TabIndex = 2;
            this.label_header_addservice.Text = "Ajouter un service";
            // 
            // label_service_type
            // 
            this.label_service_type.AutoSize = true;
            this.label_service_type.Location = new System.Drawing.Point(12, 72);
            this.label_service_type.Name = "label_service_type";
            this.label_service_type.Size = new System.Drawing.Size(92, 13);
            this.label_service_type.TabIndex = 3;
            this.label_service_type.Text = "Type du service : ";
            // 
            // combo_service_type
            // 
            this.combo_service_type.FormattingEnabled = true;
            this.combo_service_type.Location = new System.Drawing.Point(110, 69);
            this.combo_service_type.Name = "combo_service_type";
            this.combo_service_type.Size = new System.Drawing.Size(164, 21);
            this.combo_service_type.TabIndex = 10;
            // 
            // button_service_vue_ajout_ajouter
            // 
            this.button_service_vue_ajout_ajouter.BackColor = System.Drawing.Color.Transparent;
            this.button_service_vue_ajout_ajouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_service_vue_ajout_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_service_vue_ajout_ajouter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_service_vue_ajout_ajouter.Location = new System.Drawing.Point(12, 98);
            this.button_service_vue_ajout_ajouter.Name = "button_service_vue_ajout_ajouter";
            this.button_service_vue_ajout_ajouter.Rounded = false;
            this.button_service_vue_ajout_ajouter.Size = new System.Drawing.Size(106, 32);
            this.button_service_vue_ajout_ajouter.TabIndex = 12;
            this.button_service_vue_ajout_ajouter.Text = "Créer";
            this.button_service_vue_ajout_ajouter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_service_vue_ajout_ajouter.Click += new System.EventHandler(this.Button_service_vue_ajout_ajouterClick);
            // 
            // button_service_vue_ajout_annuler
            // 
            this.button_service_vue_ajout_annuler.BackColor = System.Drawing.Color.Transparent;
            this.button_service_vue_ajout_annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_service_vue_ajout_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_service_vue_ajout_annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_service_vue_ajout_annuler.Location = new System.Drawing.Point(170, 98);
            this.button_service_vue_ajout_annuler.Name = "button_service_vue_ajout_annuler";
            this.button_service_vue_ajout_annuler.Rounded = false;
            this.button_service_vue_ajout_annuler.Size = new System.Drawing.Size(106, 32);
            this.button_service_vue_ajout_annuler.TabIndex = 13;
            this.button_service_vue_ajout_annuler.Text = "Annuler";
            this.button_service_vue_ajout_annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_service_vue_ajout_annuler.Click += new System.EventHandler(this.Button_service_vue_ajout_annulerClick);
            // 
            // formAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 142);
            this.Controls.Add(this.button_service_vue_ajout_annuler);
            this.Controls.Add(this.button_service_vue_ajout_ajouter);
            this.Controls.Add(this.combo_service_type);
            this.Controls.Add(this.label_service_type);
            this.Controls.Add(this.label_header_addservice);
            this.Controls.Add(this._service_nomService);
            this.Controls.Add(this.label_service_nom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAddService";
            this.Text = "Gestion - MSL - Ajout service";
            this.Load += new System.EventHandler(this.formAddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_service_nom;
        private System.Windows.Forms.TextBox _service_nomService;
        private System.Windows.Forms.Label label_header_addservice;
        private System.Windows.Forms.Label label_service_type;
        private System.Windows.Forms.ComboBox combo_service_type;
        private FlatUI.FlatButton button_service_vue_ajout_ajouter;
        private FlatUI.FlatButton button_service_vue_ajout_annuler;
    }
}
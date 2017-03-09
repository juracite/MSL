namespace gestion.cvue.vPersonnel.vModif
{
    partial class formModifPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formModifPersonnel));
            this.label_personnel_service = new System.Windows.Forms.Label();
            this._personnel_mail = new System.Windows.Forms.TextBox();
            this.label_personnel_mail = new System.Windows.Forms.Label();
            this._personnel_prenom = new System.Windows.Forms.TextBox();
            this.label_personnel_prenom = new System.Windows.Forms.Label();
            this._personnel_nom = new System.Windows.Forms.TextBox();
            this.label_personnel_nom = new System.Windows.Forms.Label();
            this.label_header_modifpersonnel = new System.Windows.Forms.Label();
            this.button_personnel_annuler = new FlatUI.FlatButton();
            this.button_personnel_modifier = new FlatUI.FlatButton();
            this.combo_personnel_service = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_personnel_service
            // 
            this.label_personnel_service.AutoSize = true;
            this.label_personnel_service.Location = new System.Drawing.Point(7, 147);
            this.label_personnel_service.Name = "label_personnel_service";
            this.label_personnel_service.Size = new System.Drawing.Size(52, 13);
            this.label_personnel_service.TabIndex = 33;
            this.label_personnel_service.Text = "Service : ";
            // 
            // _personnel_mail
            // 
            this._personnel_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._personnel_mail.Location = new System.Drawing.Point(129, 119);
            this._personnel_mail.Name = "_personnel_mail";
            this._personnel_mail.Size = new System.Drawing.Size(183, 20);
            this._personnel_mail.TabIndex = 32;
            // 
            // label_personnel_mail
            // 
            this.label_personnel_mail.AutoSize = true;
            this.label_personnel_mail.Location = new System.Drawing.Point(7, 121);
            this.label_personnel_mail.Name = "label_personnel_mail";
            this.label_personnel_mail.Size = new System.Drawing.Size(99, 13);
            this.label_personnel_mail.TabIndex = 31;
            this.label_personnel_mail.Text = "Mail du personnel : ";
            // 
            // _personnel_prenom
            // 
            this._personnel_prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._personnel_prenom.Location = new System.Drawing.Point(129, 93);
            this._personnel_prenom.Name = "_personnel_prenom";
            this._personnel_prenom.Size = new System.Drawing.Size(183, 20);
            this._personnel_prenom.TabIndex = 30;
            // 
            // label_personnel_prenom
            // 
            this.label_personnel_prenom.AutoSize = true;
            this.label_personnel_prenom.Location = new System.Drawing.Point(7, 96);
            this.label_personnel_prenom.Name = "label_personnel_prenom";
            this.label_personnel_prenom.Size = new System.Drawing.Size(116, 13);
            this.label_personnel_prenom.TabIndex = 29;
            this.label_personnel_prenom.Text = "Prenom du personnel : ";
            // 
            // _personnel_nom
            // 
            this._personnel_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._personnel_nom.Location = new System.Drawing.Point(129, 67);
            this._personnel_nom.Name = "_personnel_nom";
            this._personnel_nom.Size = new System.Drawing.Size(183, 20);
            this._personnel_nom.TabIndex = 28;
            // 
            // label_personnel_nom
            // 
            this.label_personnel_nom.AutoSize = true;
            this.label_personnel_nom.Location = new System.Drawing.Point(7, 69);
            this.label_personnel_nom.Name = "label_personnel_nom";
            this.label_personnel_nom.Size = new System.Drawing.Size(102, 13);
            this.label_personnel_nom.TabIndex = 27;
            this.label_personnel_nom.Text = "Nom du personnel : ";
            // 
            // label_header_modifpersonnel
            // 
            this.label_header_modifpersonnel.AutoSize = true;
            this.label_header_modifpersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_modifpersonnel.Location = new System.Drawing.Point(77, 9);
            this.label_header_modifpersonnel.Name = "label_header_modifpersonnel";
            this.label_header_modifpersonnel.Size = new System.Drawing.Size(199, 25);
            this.label_header_modifpersonnel.TabIndex = 35;
            this.label_header_modifpersonnel.Text = "Modifier un personnel";
            // 
            // button_personnel_annuler
            // 
            this.button_personnel_annuler.BackColor = System.Drawing.Color.Transparent;
            this.button_personnel_annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_personnel_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personnel_annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_personnel_annuler.Location = new System.Drawing.Point(221, 190);
            this.button_personnel_annuler.Name = "button_personnel_annuler";
            this.button_personnel_annuler.Rounded = false;
            this.button_personnel_annuler.Size = new System.Drawing.Size(106, 32);
            this.button_personnel_annuler.TabIndex = 37;
            this.button_personnel_annuler.Text = "Annuler";
            this.button_personnel_annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_personnel_annuler.Click += new System.EventHandler(this.button_personnel_annuler_Click);
            // 
            // button_personnel_modifier
            // 
            this.button_personnel_modifier.BackColor = System.Drawing.Color.Transparent;
            this.button_personnel_modifier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_personnel_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personnel_modifier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_personnel_modifier.Location = new System.Drawing.Point(10, 190);
            this.button_personnel_modifier.Name = "button_personnel_modifier";
            this.button_personnel_modifier.Rounded = false;
            this.button_personnel_modifier.Size = new System.Drawing.Size(106, 32);
            this.button_personnel_modifier.TabIndex = 36;
            this.button_personnel_modifier.Text = "Modifier";
            this.button_personnel_modifier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_personnel_modifier.Click += new System.EventHandler(this.button_personnel_modifier_Click);
            // 
            // combo_personnel_service
            // 
            this.combo_personnel_service.BackColor = System.Drawing.Color.White;
            this.combo_personnel_service.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combo_personnel_service.FormattingEnabled = true;
            this.combo_personnel_service.Location = new System.Drawing.Point(129, 144);
            this.combo_personnel_service.Name = "combo_personnel_service";
            this.combo_personnel_service.Size = new System.Drawing.Size(183, 21);
            this.combo_personnel_service.Sorted = true;
            this.combo_personnel_service.TabIndex = 38;
            // 
            // formModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 240);
            this.Controls.Add(this.combo_personnel_service);
            this.Controls.Add(this.button_personnel_annuler);
            this.Controls.Add(this.button_personnel_modifier);
            this.Controls.Add(this.label_header_modifpersonnel);
            this.Controls.Add(this.label_personnel_service);
            this.Controls.Add(this._personnel_mail);
            this.Controls.Add(this.label_personnel_mail);
            this.Controls.Add(this._personnel_prenom);
            this.Controls.Add(this.label_personnel_prenom);
            this.Controls.Add(this._personnel_nom);
            this.Controls.Add(this.label_personnel_nom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formModifPersonnel";
            this.Text = "Modification du personnel";
            this.Load += new System.EventHandler(this.formModifPersonnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_personnel_service;
        private System.Windows.Forms.TextBox _personnel_mail;
        private System.Windows.Forms.Label label_personnel_mail;
        private System.Windows.Forms.TextBox _personnel_prenom;
        private System.Windows.Forms.Label label_personnel_prenom;
        private System.Windows.Forms.TextBox _personnel_nom;
        private System.Windows.Forms.Label label_personnel_nom;
        private System.Windows.Forms.Label label_header_modifpersonnel;
        private FlatUI.FlatButton button_personnel_annuler;
        private FlatUI.FlatButton button_personnel_modifier;
        private System.Windows.Forms.ComboBox combo_personnel_service;
    }
}
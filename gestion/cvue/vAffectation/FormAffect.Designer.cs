﻿namespace gestion.cvue.vAffectation
{
    partial class FormAffect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAffect));
            this.label_header_modifpersonnel = new System.Windows.Forms.Label();
            this.label_affect_marque = new System.Windows.Forms.Label();
            this.label_affect_prenom = new System.Windows.Forms.Label();
            this.label_affect_modele = new System.Windows.Forms.Label();
            this._affect_modele = new System.Windows.Forms.ComboBox();
            this._affect_marque = new System.Windows.Forms.ComboBox();
            this._affect_annee = new System.Windows.Forms.ComboBox();
            this._affect_combo_salarie = new System.Windows.Forms.ComboBox();
            this.label_affect_salarie = new System.Windows.Forms.Label();
            this._affectation_Annuler = new FlatUI.FlatButton();
            this._affectation_Modif = new FlatUI.FlatButton();
            this.SuspendLayout();
            // 
            // label_header_modifpersonnel
            // 
            this.label_header_modifpersonnel.AutoSize = true;
            this.label_header_modifpersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_modifpersonnel.Location = new System.Drawing.Point(61, 9);
            this.label_header_modifpersonnel.Name = "label_header_modifpersonnel";
            this.label_header_modifpersonnel.Size = new System.Drawing.Size(183, 25);
            this.label_header_modifpersonnel.TabIndex = 36;
            this.label_header_modifpersonnel.Text = "Affecter un vehicule";
            // 
            // label_affect_marque
            // 
            this.label_affect_marque.AutoSize = true;
            this.label_affect_marque.Location = new System.Drawing.Point(45, 78);
            this.label_affect_marque.Name = "label_affect_marque";
            this.label_affect_marque.Size = new System.Drawing.Size(49, 13);
            this.label_affect_marque.TabIndex = 43;
            this.label_affect_marque.Text = "Marque :";
            // 
            // label_affect_prenom
            // 
            this.label_affect_prenom.AutoSize = true;
            this.label_affect_prenom.Location = new System.Drawing.Point(45, 132);
            this.label_affect_prenom.Name = "label_affect_prenom";
            this.label_affect_prenom.Size = new System.Drawing.Size(44, 13);
            this.label_affect_prenom.TabIndex = 41;
            this.label_affect_prenom.Text = "Année :";
            // 
            // label_affect_modele
            // 
            this.label_affect_modele.AutoSize = true;
            this.label_affect_modele.Location = new System.Drawing.Point(45, 105);
            this.label_affect_modele.Name = "label_affect_modele";
            this.label_affect_modele.Size = new System.Drawing.Size(48, 13);
            this.label_affect_modele.TabIndex = 39;
            this.label_affect_modele.Text = "Modele :";
            // 
            // _affect_modele
            // 
            this._affect_modele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._affect_modele.Enabled = false;
            this._affect_modele.FormattingEnabled = true;
            this._affect_modele.Location = new System.Drawing.Point(123, 102);
            this._affect_modele.Name = "_affect_modele";
            this._affect_modele.Size = new System.Drawing.Size(121, 21);
            this._affect_modele.TabIndex = 45;
            this._affect_modele.SelectedIndexChanged += new System.EventHandler(this._affect_modele_SelectedIndexChanged);
            // 
            // _affect_marque
            // 
            this._affect_marque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._affect_marque.Enabled = false;
            this._affect_marque.FormattingEnabled = true;
            this._affect_marque.Location = new System.Drawing.Point(123, 75);
            this._affect_marque.Name = "_affect_marque";
            this._affect_marque.Size = new System.Drawing.Size(121, 21);
            this._affect_marque.TabIndex = 46;
            this._affect_marque.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _affect_annee
            // 
            this._affect_annee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._affect_annee.Enabled = false;
            this._affect_annee.FormattingEnabled = true;
            this._affect_annee.Location = new System.Drawing.Point(123, 129);
            this._affect_annee.Name = "_affect_annee";
            this._affect_annee.Size = new System.Drawing.Size(121, 21);
            this._affect_annee.TabIndex = 47;
            // 
            // _affect_combo_salarie
            // 
            this._affect_combo_salarie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._affect_combo_salarie.FormattingEnabled = true;
            this._affect_combo_salarie.Location = new System.Drawing.Point(123, 48);
            this._affect_combo_salarie.Name = "_affect_combo_salarie";
            this._affect_combo_salarie.Size = new System.Drawing.Size(121, 21);
            this._affect_combo_salarie.TabIndex = 49;
            this._affect_combo_salarie.SelectedIndexChanged += new System.EventHandler(this._affect_combo_salarie_SelectedIndexChanged);
            // 
            // label_affect_salarie
            // 
            this.label_affect_salarie.AutoSize = true;
            this.label_affect_salarie.Location = new System.Drawing.Point(44, 51);
            this.label_affect_salarie.Name = "label_affect_salarie";
            this.label_affect_salarie.Size = new System.Drawing.Size(45, 13);
            this.label_affect_salarie.TabIndex = 48;
            this.label_affect_salarie.Text = "Salarié :";
            // 
            // _affectation_Annuler
            // 
            this._affectation_Annuler.BackColor = System.Drawing.Color.Transparent;
            this._affectation_Annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._affectation_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this._affectation_Annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._affectation_Annuler.Location = new System.Drawing.Point(166, 167);
            this._affectation_Annuler.Name = "_affectation_Annuler";
            this._affectation_Annuler.Rounded = false;
            this._affectation_Annuler.Size = new System.Drawing.Size(106, 32);
            this._affectation_Annuler.TabIndex = 1;
            this._affectation_Annuler.Text = "Annuler";
            this._affectation_Annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this._affectation_Annuler.Click += new System.EventHandler(this._affectation_Annuler_Click);
            // 
            // _affectation_Modif
            // 
            this._affectation_Modif.BackColor = System.Drawing.Color.Transparent;
            this._affectation_Modif.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this._affectation_Modif.Cursor = System.Windows.Forms.Cursors.Hand;
            this._affectation_Modif.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._affectation_Modif.Location = new System.Drawing.Point(12, 167);
            this._affectation_Modif.Name = "_affectation_Modif";
            this._affectation_Modif.Rounded = false;
            this._affectation_Modif.Size = new System.Drawing.Size(106, 32);
            this._affectation_Modif.TabIndex = 0;
            this._affectation_Modif.Text = "Modifier";
            this._affectation_Modif.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this._affectation_Modif.Click += new System.EventHandler(this._affectation_Modif_Click);
            // 
            // FormAffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this._affect_combo_salarie);
            this.Controls.Add(this.label_affect_salarie);
            this.Controls.Add(this._affect_annee);
            this.Controls.Add(this._affect_marque);
            this.Controls.Add(this._affect_modele);
            this.Controls.Add(this.label_affect_marque);
            this.Controls.Add(this.label_affect_prenom);
            this.Controls.Add(this.label_affect_modele);
            this.Controls.Add(this.label_header_modifpersonnel);
            this.Controls.Add(this._affectation_Annuler);
            this.Controls.Add(this._affectation_Modif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAffect";
            this.Text = "Affectation vehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatButton _affectation_Modif;
        private FlatUI.FlatButton _affectation_Annuler;
        private System.Windows.Forms.Label label_header_modifpersonnel;
        private System.Windows.Forms.Label label_affect_marque;
        private System.Windows.Forms.Label label_affect_prenom;
        private System.Windows.Forms.Label label_affect_modele;
        private System.Windows.Forms.ComboBox _affect_modele;
        private System.Windows.Forms.ComboBox _affect_marque;
        private System.Windows.Forms.ComboBox _affect_annee;
        private System.Windows.Forms.ComboBox _affect_combo_salarie;
        private System.Windows.Forms.Label label_affect_salarie;
    }
}
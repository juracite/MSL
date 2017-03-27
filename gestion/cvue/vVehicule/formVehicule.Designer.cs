namespace gestion.cvue.vVehicule
{
    partial class formVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVehicule));
            this._vehicule_marque = new System.Windows.Forms.TextBox();
            this.label_vehicule_marque = new System.Windows.Forms.Label();
            this._vehicule_annee = new System.Windows.Forms.TextBox();
            this.label_personnel_prenom = new System.Windows.Forms.Label();
            this._vehicule_modele = new System.Windows.Forms.TextBox();
            this.label_vehicule_modele = new System.Windows.Forms.Label();
            this.label_header_modifvehicule = new System.Windows.Forms.Label();
            this.button_vehicule_annuler = new FlatUI.FlatButton();
            this.button_vehicule_modifier = new FlatUI.FlatButton();
            this.SuspendLayout();
            // 
            // _vehicule_marque
            // 
            this._vehicule_marque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._vehicule_marque.Location = new System.Drawing.Point(95, 125);
            this._vehicule_marque.Name = "_vehicule_marque";
            this._vehicule_marque.Size = new System.Drawing.Size(183, 20);
            this._vehicule_marque.TabIndex = 38;
            // 
            // label_vehicule_marque
            // 
            this.label_vehicule_marque.AutoSize = true;
            this.label_vehicule_marque.Location = new System.Drawing.Point(10, 127);
            this.label_vehicule_marque.Name = "label_vehicule_marque";
            this.label_vehicule_marque.Size = new System.Drawing.Size(49, 13);
            this.label_vehicule_marque.TabIndex = 37;
            this.label_vehicule_marque.Text = "Marque :";
            // 
            // _vehicule_annee
            // 
            this._vehicule_annee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._vehicule_annee.Location = new System.Drawing.Point(95, 99);
            this._vehicule_annee.Name = "_vehicule_annee";
            this._vehicule_annee.Size = new System.Drawing.Size(183, 20);
            this._vehicule_annee.TabIndex = 36;
            // 
            // label_personnel_prenom
            // 
            this.label_personnel_prenom.AutoSize = true;
            this.label_personnel_prenom.Location = new System.Drawing.Point(10, 102);
            this.label_personnel_prenom.Name = "label_personnel_prenom";
            this.label_personnel_prenom.Size = new System.Drawing.Size(44, 13);
            this.label_personnel_prenom.TabIndex = 35;
            this.label_personnel_prenom.Text = "Année :";
            // 
            // _vehicule_modele
            // 
            this._vehicule_modele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._vehicule_modele.Location = new System.Drawing.Point(95, 73);
            this._vehicule_modele.Name = "_vehicule_modele";
            this._vehicule_modele.Size = new System.Drawing.Size(183, 20);
            this._vehicule_modele.TabIndex = 34;
            // 
            // label_vehicule_modele
            // 
            this.label_vehicule_modele.AutoSize = true;
            this.label_vehicule_modele.Location = new System.Drawing.Point(10, 75);
            this.label_vehicule_modele.Name = "label_vehicule_modele";
            this.label_vehicule_modele.Size = new System.Drawing.Size(48, 13);
            this.label_vehicule_modele.TabIndex = 33;
            this.label_vehicule_modele.Text = "Modele :";
            // 
            // label_header_modifvehicule
            // 
            this.label_header_modifvehicule.AutoSize = true;
            this.label_header_modifvehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_modifvehicule.Location = new System.Drawing.Point(90, 21);
            this.label_header_modifvehicule.Name = "label_header_modifvehicule";
            this.label_header_modifvehicule.Size = new System.Drawing.Size(185, 25);
            this.label_header_modifvehicule.TabIndex = 39;
            this.label_header_modifvehicule.Text = "Modifier un véhicule";
            // 
            // button_vehicule_annuler
            // 
            this.button_vehicule_annuler.BackColor = System.Drawing.Color.Transparent;
            this.button_vehicule_annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_vehicule_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vehicule_annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_vehicule_annuler.Location = new System.Drawing.Point(234, 184);
            this.button_vehicule_annuler.Name = "button_vehicule_annuler";
            this.button_vehicule_annuler.Rounded = false;
            this.button_vehicule_annuler.Size = new System.Drawing.Size(106, 32);
            this.button_vehicule_annuler.TabIndex = 41;
            this.button_vehicule_annuler.Text = "Annuler";
            this.button_vehicule_annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_vehicule_annuler.Click += new System.EventHandler(this.button_vehicule_annuler_Click);
            // 
            // button_vehicule_modifier
            // 
            this.button_vehicule_modifier.BackColor = System.Drawing.Color.Transparent;
            this.button_vehicule_modifier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_vehicule_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vehicule_modifier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_vehicule_modifier.Location = new System.Drawing.Point(23, 184);
            this.button_vehicule_modifier.Name = "button_vehicule_modifier";
            this.button_vehicule_modifier.Rounded = false;
            this.button_vehicule_modifier.Size = new System.Drawing.Size(106, 32);
            this.button_vehicule_modifier.TabIndex = 40;
            this.button_vehicule_modifier.Text = "Modifier";
            this.button_vehicule_modifier.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // formVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 257);
            this.Controls.Add(this.button_vehicule_annuler);
            this.Controls.Add(this.button_vehicule_modifier);
            this.Controls.Add(this.label_header_modifvehicule);
            this.Controls.Add(this._vehicule_marque);
            this.Controls.Add(this.label_vehicule_marque);
            this.Controls.Add(this._vehicule_annee);
            this.Controls.Add(this.label_personnel_prenom);
            this.Controls.Add(this._vehicule_modele);
            this.Controls.Add(this.label_vehicule_modele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formVehicule";
            this.Text = "formVehicule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _vehicule_marque;
        private System.Windows.Forms.Label label_vehicule_marque;
        private System.Windows.Forms.TextBox _vehicule_annee;
        private System.Windows.Forms.Label label_personnel_prenom;
        private System.Windows.Forms.TextBox _vehicule_modele;
        private System.Windows.Forms.Label label_vehicule_modele;
        private System.Windows.Forms.Label label_header_modifvehicule;
        private FlatUI.FlatButton button_vehicule_annuler;
        private FlatUI.FlatButton button_vehicule_modifier;
    }
}
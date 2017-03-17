namespace gestion.cvue.vVehicule.vListeEntretien
{
    partial class formEntretienListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEntretienListe));
            this.label_header_listeEntretien = new FlatUI.FlatLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_entretien_rdv = new FlatUI.FlatButton();
            this.button_entretien_annuler = new FlatUI.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header_listeEntretien
            // 
            this.label_header_listeEntretien.AutoSize = true;
            this.label_header_listeEntretien.BackColor = System.Drawing.Color.Transparent;
            this.label_header_listeEntretien.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label_header_listeEntretien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_header_listeEntretien.Location = new System.Drawing.Point(144, 9);
            this.label_header_listeEntretien.Name = "label_header_listeEntretien";
            this.label_header_listeEntretien.Size = new System.Drawing.Size(275, 28);
            this.label_header_listeEntretien.TabIndex = 0;
            this.label_header_listeEntretien.Text = "Liste des véhicules à entretenir";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.imma});
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(536, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // imma
            // 
            this.imma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imma.HeaderText = "Immatriculation";
            this.imma.Name = "imma";
            // 
            // button_entretien_rdv
            // 
            this.button_entretien_rdv.BackColor = System.Drawing.Color.Transparent;
            this.button_entretien_rdv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_entretien_rdv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_entretien_rdv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_entretien_rdv.Location = new System.Drawing.Point(12, 317);
            this.button_entretien_rdv.Name = "button_entretien_rdv";
            this.button_entretien_rdv.Rounded = false;
            this.button_entretien_rdv.Size = new System.Drawing.Size(111, 41);
            this.button_entretien_rdv.TabIndex = 2;
            this.button_entretien_rdv.Text = "Prendre RDV";
            this.button_entretien_rdv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_entretien_rdv.Click += new System.EventHandler(this.button_entretien_rdv_Click);
            // 
            // button_entretien_annuler
            // 
            this.button_entretien_annuler.BackColor = System.Drawing.Color.Transparent;
            this.button_entretien_annuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_entretien_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_entretien_annuler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_entretien_annuler.Location = new System.Drawing.Point(437, 317);
            this.button_entretien_annuler.Name = "button_entretien_annuler";
            this.button_entretien_annuler.Rounded = false;
            this.button_entretien_annuler.Size = new System.Drawing.Size(111, 41);
            this.button_entretien_annuler.TabIndex = 3;
            this.button_entretien_annuler.Text = "Annuler";
            this.button_entretien_annuler.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_entretien_annuler.Click += new System.EventHandler(this.button_entretien_annuler_Click);
            // 
            // formEntretienListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 370);
            this.Controls.Add(this.button_entretien_annuler);
            this.Controls.Add(this.button_entretien_rdv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_header_listeEntretien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formEntretienListe";
            this.Text = "Entretien des véhicules";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatLabel label_header_listeEntretien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn imma;
        private FlatUI.FlatButton button_entretien_rdv;
        private FlatUI.FlatButton button_entretien_annuler;
    }
}
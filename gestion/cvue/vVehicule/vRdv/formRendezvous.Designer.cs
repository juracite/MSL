namespace gestion.cvue.vVehicule.vRdv
{
    partial class formRendezvous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRendezvous));
            this.tc_rdv = new FlatUI.FlatTabControl();
            this.tp_rdv = new System.Windows.Forms.TabPage();
            this.button_reset = new FlatUI.FlatButton();
            this.button_ajouter = new FlatUI.FlatButton();
            this.comm_rdv = new FlatUI.FlatTextBox();
            this.list_typeEnt = new System.Windows.Forms.ListBox();
            this.label_typeEnt = new FlatUI.FlatLabel();
            this.label_minute = new FlatUI.FlatLabel();
            this.track_minute = new FlatUI.FlatTrackBar();
            this.label_heure_minute = new FlatUI.FlatLabel();
            this.label_heure = new FlatUI.FlatLabel();
            this.track_heure = new FlatUI.FlatTrackBar();
            this.date_rdv = new System.Windows.Forms.DateTimePicker();
            this.label_date = new FlatUI.FlatLabel();
            this.tp_listrdv = new System.Windows.Forms.TabPage();
            this.button_quit = new FlatUI.FlatButton();
            this.button_supprimer = new FlatUI.FlatButton();
            this.dgv_rdv = new System.Windows.Forms.DataGridView();
            this.imma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_rdv.SuspendLayout();
            this.tp_rdv.SuspendLayout();
            this.tp_listrdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rdv)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_rdv
            // 
            this.tc_rdv.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.tc_rdv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.tc_rdv.Controls.Add(this.tp_rdv);
            this.tc_rdv.Controls.Add(this.tp_listrdv);
            this.tc_rdv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tc_rdv.ItemSize = new System.Drawing.Size(120, 40);
            this.tc_rdv.Location = new System.Drawing.Point(12, 12);
            this.tc_rdv.Name = "tc_rdv";
            this.tc_rdv.SelectedIndex = 0;
            this.tc_rdv.Size = new System.Drawing.Size(583, 306);
            this.tc_rdv.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_rdv.TabIndex = 0;
            // 
            // tp_rdv
            // 
            this.tp_rdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tp_rdv.Controls.Add(this.button_reset);
            this.tp_rdv.Controls.Add(this.button_ajouter);
            this.tp_rdv.Controls.Add(this.comm_rdv);
            this.tp_rdv.Controls.Add(this.list_typeEnt);
            this.tp_rdv.Controls.Add(this.label_typeEnt);
            this.tp_rdv.Controls.Add(this.label_minute);
            this.tp_rdv.Controls.Add(this.track_minute);
            this.tp_rdv.Controls.Add(this.label_heure_minute);
            this.tp_rdv.Controls.Add(this.label_heure);
            this.tp_rdv.Controls.Add(this.track_heure);
            this.tp_rdv.Controls.Add(this.date_rdv);
            this.tp_rdv.Controls.Add(this.label_date);
            this.tp_rdv.Location = new System.Drawing.Point(4, 44);
            this.tp_rdv.Name = "tp_rdv";
            this.tp_rdv.Padding = new System.Windows.Forms.Padding(3);
            this.tp_rdv.Size = new System.Drawing.Size(575, 258);
            this.tp_rdv.TabIndex = 1;
            this.tp_rdv.Text = "Saisi d\'un RDV";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Transparent;
            this.button_reset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_reset.Location = new System.Drawing.Point(463, 220);
            this.button_reset.Name = "button_reset";
            this.button_reset.Rounded = false;
            this.button_reset.Size = new System.Drawing.Size(106, 32);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "Réinitialiser";
            this.button_reset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.BackColor = System.Drawing.Color.Transparent;
            this.button_ajouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ajouter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_ajouter.Location = new System.Drawing.Point(463, 143);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Rounded = false;
            this.button_ajouter.Size = new System.Drawing.Size(106, 32);
            this.button_ajouter.TabIndex = 12;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // comm_rdv
            // 
            this.comm_rdv.BackColor = System.Drawing.Color.Transparent;
            this.comm_rdv.FocusOnHover = false;
            this.comm_rdv.Location = new System.Drawing.Point(7, 143);
            this.comm_rdv.MaxLength = 32767;
            this.comm_rdv.Multiline = true;
            this.comm_rdv.Name = "comm_rdv";
            this.comm_rdv.ReadOnly = false;
            this.comm_rdv.Size = new System.Drawing.Size(450, 109);
            this.comm_rdv.TabIndex = 11;
            this.comm_rdv.Text = "Commentaire à propos du rendez-vous...";
            this.comm_rdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.comm_rdv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comm_rdv.UseSystemPasswordChar = false;
            // 
            // list_typeEnt
            // 
            this.list_typeEnt.FormattingEnabled = true;
            this.list_typeEnt.ItemHeight = 17;
            this.list_typeEnt.Items.AddRange(new object[] {
            "1 - Frein",
            "2 - Pneu",
            "3 - Huile vidange"});
            this.list_typeEnt.Location = new System.Drawing.Point(311, 44);
            this.list_typeEnt.Name = "list_typeEnt";
            this.list_typeEnt.Size = new System.Drawing.Size(258, 89);
            this.list_typeEnt.TabIndex = 10;
            // 
            // label_typeEnt
            // 
            this.label_typeEnt.AutoSize = true;
            this.label_typeEnt.BackColor = System.Drawing.Color.Transparent;
            this.label_typeEnt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_typeEnt.ForeColor = System.Drawing.Color.White;
            this.label_typeEnt.Location = new System.Drawing.Point(384, 13);
            this.label_typeEnt.Name = "label_typeEnt";
            this.label_typeEnt.Size = new System.Drawing.Size(108, 19);
            this.label_typeEnt.TabIndex = 9;
            this.label_typeEnt.Text = "Type d\'entretien";
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.BackColor = System.Drawing.Color.Transparent;
            this.label_minute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_minute.ForeColor = System.Drawing.Color.White;
            this.label_minute.Location = new System.Drawing.Point(3, 114);
            this.label_minute.Name = "label_minute";
            this.label_minute.Size = new System.Drawing.Size(74, 19);
            this.label_minute.TabIndex = 7;
            this.label_minute.Text = "Minute(s) :";
            // 
            // track_minute
            // 
            this.track_minute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.track_minute.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.track_minute.Location = new System.Drawing.Point(74, 114);
            this.track_minute.Maximum = 59;
            this.track_minute.Minimum = 0;
            this.track_minute.Name = "track_minute";
            this.track_minute.ShowValue = false;
            this.track_minute.Size = new System.Drawing.Size(200, 23);
            this.track_minute.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.track_minute.TabIndex = 6;
            this.track_minute.Text = "Heure";
            this.track_minute.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.track_minute.Value = 30;
            this.track_minute.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.track_minute_Scroll);
            // 
            // label_heure_minute
            // 
            this.label_heure_minute.AutoSize = true;
            this.label_heure_minute.BackColor = System.Drawing.Color.Transparent;
            this.label_heure_minute.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_heure_minute.ForeColor = System.Drawing.Color.White;
            this.label_heure_minute.Location = new System.Drawing.Point(158, 98);
            this.label_heure_minute.Name = "label_heure_minute";
            this.label_heure_minute.Size = new System.Drawing.Size(44, 13);
            this.label_heure_minute.TabIndex = 5;
            this.label_heure_minute.Text = "15 h 30";
            // 
            // label_heure
            // 
            this.label_heure.AutoSize = true;
            this.label_heure.BackColor = System.Drawing.Color.Transparent;
            this.label_heure.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_heure.ForeColor = System.Drawing.Color.White;
            this.label_heure.Location = new System.Drawing.Point(15, 72);
            this.label_heure.Name = "label_heure";
            this.label_heure.Size = new System.Drawing.Size(53, 19);
            this.label_heure.TabIndex = 4;
            this.label_heure.Text = "Heure :";
            // 
            // track_heure
            // 
            this.track_heure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.track_heure.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.track_heure.Location = new System.Drawing.Point(74, 72);
            this.track_heure.Maximum = 19;
            this.track_heure.Minimum = 0;
            this.track_heure.Name = "track_heure";
            this.track_heure.ShowValue = false;
            this.track_heure.Size = new System.Drawing.Size(200, 23);
            this.track_heure.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.track_heure.TabIndex = 3;
            this.track_heure.Text = "Heure";
            this.track_heure.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.track_heure.Value = 15;
            this.track_heure.Scroll += new FlatUI.FlatTrackBar.ScrollEventHandler(this.track_heure_Scroll);
            // 
            // date_rdv
            // 
            this.date_rdv.Location = new System.Drawing.Point(74, 30);
            this.date_rdv.Name = "date_rdv";
            this.date_rdv.Size = new System.Drawing.Size(200, 25);
            this.date_rdv.TabIndex = 2;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(19, 32);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(49, 19);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date : ";
            // 
            // tp_listrdv
            // 
            this.tp_listrdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tp_listrdv.Controls.Add(this.button_quit);
            this.tp_listrdv.Controls.Add(this.button_supprimer);
            this.tp_listrdv.Controls.Add(this.dgv_rdv);
            this.tp_listrdv.Location = new System.Drawing.Point(4, 44);
            this.tp_listrdv.Name = "tp_listrdv";
            this.tp_listrdv.Padding = new System.Windows.Forms.Padding(3);
            this.tp_listrdv.Size = new System.Drawing.Size(575, 258);
            this.tp_listrdv.TabIndex = 2;
            this.tp_listrdv.Text = "Liste RDV";
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.Color.Transparent;
            this.button_quit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit.Enabled = false;
            this.button_quit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_quit.Location = new System.Drawing.Point(463, 217);
            this.button_quit.Name = "button_quit";
            this.button_quit.Rounded = false;
            this.button_quit.Size = new System.Drawing.Size(106, 32);
            this.button_quit.TabIndex = 3;
            this.button_quit.Text = "Quitter";
            this.button_quit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_quit.Visible = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.Transparent;
            this.button_supprimer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_supprimer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_supprimer.Location = new System.Drawing.Point(6, 217);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Rounded = false;
            this.button_supprimer.Size = new System.Drawing.Size(106, 32);
            this.button_supprimer.TabIndex = 2;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // dgv_rdv
            // 
            this.dgv_rdv.AllowUserToAddRows = false;
            this.dgv_rdv.AllowUserToDeleteRows = false;
            this.dgv_rdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imma,
            this.date,
            this.heure,
            this.commentaire});
            this.dgv_rdv.Location = new System.Drawing.Point(6, 6);
            this.dgv_rdv.MultiSelect = false;
            this.dgv_rdv.Name = "dgv_rdv";
            this.dgv_rdv.ReadOnly = true;
            this.dgv_rdv.RowHeadersVisible = false;
            this.dgv_rdv.Size = new System.Drawing.Size(563, 205);
            this.dgv_rdv.TabIndex = 1;
            // 
            // imma
            // 
            this.imma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imma.HeaderText = "Immatriculation";
            this.imma.Name = "imma";
            this.imma.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // heure
            // 
            this.heure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heure.HeaderText = "Heure";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            // 
            // commentaire
            // 
            this.commentaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentaire.HeaderText = "Commentaire";
            this.commentaire.Name = "commentaire";
            this.commentaire.ReadOnly = true;
            // 
            // formRendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 330);
            this.Controls.Add(this.tc_rdv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formRendezvous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prise de rendez-vous";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formRendezvous_Load);
            this.tc_rdv.ResumeLayout(false);
            this.tp_rdv.ResumeLayout(false);
            this.tp_rdv.PerformLayout();
            this.tp_listrdv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatTabControl tc_rdv;
        private System.Windows.Forms.TabPage tp_rdv;
        private System.Windows.Forms.TabPage tp_listrdv;
        private FlatUI.FlatLabel label_heure;
        private FlatUI.FlatTrackBar track_heure;
        private System.Windows.Forms.DateTimePicker date_rdv;
        private FlatUI.FlatLabel label_date;
        private System.Windows.Forms.DataGridView dgv_rdv;
        private FlatUI.FlatLabel label_heure_minute;
        private FlatUI.FlatLabel label_typeEnt;
        private FlatUI.FlatLabel label_minute;
        private FlatUI.FlatTrackBar track_minute;
        private System.Windows.Forms.ListBox list_typeEnt;
        private FlatUI.FlatTextBox comm_rdv;
        private FlatUI.FlatButton button_reset;
        private FlatUI.FlatButton button_ajouter;
        private FlatUI.FlatButton button_supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn imma;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaire;
        private FlatUI.FlatButton button_quit;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion
{
    public partial class form_gestion : Form
    {
        string myConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=commune;" + "convert zero datetime=True;";
        public static MySqlConnection instance;
       
        public form_gestion()
        {
            InitializeComponent();

            try
            {
                instance = cdata.AccesDB.DB.getInstance().getConnect(myConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            button_annuler.red = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gérerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cvue.vService.formService form_service = new cvue.vService.formService();
            form_service.Show();
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_gestion.ActiveForm.Close();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cvue.vPersonnel.formPersonnel formPersonnel = new cvue.vPersonnel.formPersonnel();
            formPersonnel.Show();
        }

        private void form_gestion_Load(object sender, EventArgs e)
        {

        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cvue.vVehicule.formVehiculeMarque formVehicule = new cvue.vVehicule.formVehiculeMarque();
            formVehicule.Show();
        }

        private void affectationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cvue.vAffectation.FormAffect formAffect = new cvue.vAffectation.FormAffect();
            formAffect.Show();
        }

        private void listeEntretiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cvue.vVehicule.vListeEntretien.formEntretienListe formEnt = new cvue.vVehicule.vListeEntretien.formEntretienListe();
            formEnt.Show();
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            if (textbox_login.Text == "msl_user_gestion" && textbox_mdp.Text == "msl_mdp_gestion")
            {
                if(alert_info.Visible == false)
                {
                    alert_info.Visible = true;
                }
                strip_menu.Enabled = true;
                alert_info.kind = FlatUI.FlatAlertBox._Kind.Success;
                alert_info.Text = "Vous êtes bien connecté, vous pouvez à présent utiliser le programme";

            } else {
                if (alert_info.Visible == false)
                {
                    alert_info.Visible = true;
                }
                alert_info.kind = FlatUI.FlatAlertBox._Kind.Error;
                alert_info.Text = "Mot de passe ou login erronée, veuillez réessayer";

            }
        }
    }
}
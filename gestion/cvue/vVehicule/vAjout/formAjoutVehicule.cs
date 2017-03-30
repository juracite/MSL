using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion.cvue.vVehicule.vAjout
{
    public partial class formAjoutVehicule : Form
    {
        cdata.vehiculeDb vehiculedb = new cdata.vehiculeDb();
        cdata.personnelDb personneldb = new cdata.personnelDb();

        public void reading()
        {
            List<cmetier.Vehicule> list_vehicules = new List<cmetier.Vehicule>();
            list_vehicules = vehiculedb.getDisctinctVehiculesMarque();

            foreach (cmetier.Vehicule vehicule in list_vehicules)
            {
                _combo_ajout_marque.Items.Add(vehicule.Marque);
            }
            _combo_ajout_marque.SelectedIndex = 0;


            List<cmetier.Vehicule> list_vehicules_modeles = new List<cmetier.Vehicule>();
            list_vehicules_modeles = vehiculedb.getDistinctVehiculesModele(_combo_ajout_marque.SelectedItem.ToString());

            foreach (cmetier.Vehicule vehicule_modele in list_vehicules_modeles)
            {
                _combo_ajout_modele.Items.Add(vehicule_modele.Modele);
            }
            _combo_ajout_modele.SelectedIndex = 0;
        }

        public formAjoutVehicule()
        {
            InitializeComponent();
            _ajout_Annuler.red = true;
            reading();
            arlette_ajout_info.Visible = true;
            _ajout_combo_motorisation.SelectedIndex = 0;
        }

        private void _ajout_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _affectation_affecter_Click(object sender, EventArgs e)
        {
            if(_combo_ajout_annee.Enabled = false || _combo_ajout_modele.Enabled == false ||
                _combo_ajout_marque.Enabled == false || _ajout_combo_motorisation.SelectedItem.ToString() == "")
            {
                arlette_ajout_info.Text = "Les champs doivent être remplis !";
                arlette_ajout_info.kind = FlatUI.FlatAlertBox._Kind.Error;
            }
            else if(_ajout_numeric_kmcompteur.Value > 999999) {
                arlette_ajout_info.Text = "Le nombre de km est bien trop grand !";
                arlette_ajout_info.kind = FlatUI.FlatAlertBox._Kind.Error;
            }
            else{
                arlette_ajout_info.Text = "Le véhicule a bien été ajouté !";
                arlette_ajout_info.kind = FlatUI.FlatAlertBox._Kind.Success;

                string id_vehicule = vehiculedb.getVehiculeId(_combo_ajout_marque.SelectedItem.ToString(), _combo_ajout_modele.SelectedItem.ToString(), _combo_ajout_annee.SelectedItem.ToString());

                try
                {
                    vehiculedb.setVehicule(id_vehicule, _ajout_imma.Text, , _ajout_numeric_kmcompteur.Value.ToString(), _ajout_combo_motorisation.SelectedItem.ToString());
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(_combo_ajout_annee.SelectedItem.ToString());
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void t_ajout_checkLength_imma_Tick(object sender, EventArgs e)
        {
            int lengthimma = _ajout_imma.Text.Length;
            if (lengthimma == 8)
            {
                _combo_ajout_marque.Enabled = true;
                _combo_ajout_modele.Enabled = true;
                _combo_ajout_annee.Enabled = true;

                string maj_imma = _ajout_imma.Text.ToUpper();
                _ajout_imma.Text = maj_imma;
            }
            else
            {
                _combo_ajout_marque.Enabled = false;
                _combo_ajout_modele.Enabled = false;
                _combo_ajout_annee.Enabled = false;
            }
        }

        private void _combo_ajout_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            _combo_ajout_modele.Items.Clear();
            _combo_ajout_annee.Items.Clear();
            List<cmetier.Vehicule> list_vehicules_modeles = new List<cmetier.Vehicule>();
            list_vehicules_modeles = vehiculedb.getDistinctVehiculesModele(_combo_ajout_marque.SelectedItem.ToString());

            foreach (cmetier.Vehicule vehicule_modele in list_vehicules_modeles)
            {
                _combo_ajout_modele.Items.Add(vehicule_modele.Modele);
            }
            _combo_ajout_modele.SelectedIndex = 0;
        }

        private void _combo_ajout_modele_SelectedIndexChanged(object sender, EventArgs e)
        {
            _combo_ajout_annee.Items.Clear();
            List<cmetier.Vehicule> list_vehicules_annee = new List<cmetier.Vehicule>();
            list_vehicules_annee = vehiculedb.getDistinctVehiculesAnnee(_combo_ajout_marque.SelectedItem.ToString(), _combo_ajout_modele.SelectedItem.ToString());

            foreach (cmetier.Vehicule vehicule_annee in list_vehicules_annee)
            {
                _combo_ajout_annee.Items.Add(vehicule_annee.Annee);
            }
            _combo_ajout_annee.SelectedIndex = 0;
        }
    }


   /* private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ajout_modele.Items.Clear();
            List<cmetier.Vehicule> list_vehicules_modeles = new List<cmetier.Vehicule>();
            list_vehicules_modeles = vehiculedb.getDistinctVehiculesModele(_ajout_marque.SelectedItem.ToString());

            foreach (cmetier.Vehicule vehicule_modele in list_vehicules_modeles)
            {
                _ajout_modele.Items.Add(vehicule_modele.Modele);
            }
        }*/
}

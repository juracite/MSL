using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion.cvue.vAffectation
{
    public partial class FormAffect : Form
    {

        cdata.vehiculeDb vehiculedb = new cdata.vehiculeDb();
        cdata.personnelDb personneldb = new cdata.personnelDb();

        public void reading()
        {
            List<cmetier.Vehicule> list_vehicules = new List<cmetier.Vehicule>();
            list_vehicules = vehiculedb.getDisctinctVehiculesMarque();
            
            foreach (cmetier.Vehicule vehicule in list_vehicules)
            {
                _affect_marque.Items.Add(vehicule.Marque);
            }
            _affect_marque.SelectedIndex = 0;

            List<cmetier.Personnel> list_personnels = new List<cmetier.Personnel>();
            list_personnels = personneldb.sendReqInfo();

            foreach(cmetier.Personnel personnel in list_personnels)
            {
                _affect_combo_salarie.Items.Add(personnel.Prenom[0] + "." + personnel.Nom);
            }
            _affect_combo_salarie.SelectedIndex = 0;

            List<cmetier.Vehicule> list_vehicules_modeles = new List<cmetier.Vehicule>();
            list_vehicules_modeles = vehiculedb.getDistinctVehiculesModele(_affect_marque.SelectedItem.ToString());

            foreach (cmetier.Vehicule vehicule_modele in list_vehicules_modeles)
            {
                _affect_modele.Items.Add(vehicule_modele.Modele);
            }

            List<cmetier.Vehicule> list_vehicules_annee = new List<cmetier.Vehicule>();
            try
            {
                list_vehicules_annee = vehiculedb.getDistinctVehiculesAnnee(_affect_marque.SelectedItem.ToString(), _affect_modele.SelectedItem.ToString());
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (cmetier.Vehicule vehicule_annee in list_vehicules_annee)
            {
                _affect_modele.Items.Add(vehicule_annee.Annee);
            }
        }

        public FormAffect()
        {
            InitializeComponent();
            _affectation_Annuler.red = true;
            reading();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _affect_modele.Items.Clear();
            List<cmetier.Vehicule> list_vehicules_modeles = new List<cmetier.Vehicule>();
            list_vehicules_modeles = vehiculedb.getDistinctVehiculesModele(_affect_marque.SelectedItem.ToString());

            foreach (cmetier.Vehicule vehicule_modele in list_vehicules_modeles)
            {
                _affect_modele.Items.Add(vehicule_modele.Modele);
            }
        }

        private void _affectation_Modif_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void _affectation_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _affect_combo_salarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            _affect_marque.Enabled = true;
            _affect_modele.Enabled = true;
            _affect_annee.Enabled = true;
        }

        private void _affect_modele_SelectedIndexChanged(object sender, EventArgs e)
        {
            _affect_annee.Items.Clear();
            List<cmetier.Vehicule> list_vehicules_annee = new List<cmetier.Vehicule>();
            list_vehicules_annee = vehiculedb.getDistinctVehiculesAnnee(_affect_marque.SelectedItem.ToString(), _affect_modele.SelectedItem.ToString());

            foreach (cmetier.Vehicule vehicule_annee in list_vehicules_annee)
            {
                _affect_modele.Items.Add(vehicule_annee.Annee);
            }
        }
    }
}
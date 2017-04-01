using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion.cvue.vVehicule
{
    public partial class formVehiculeMarque : Form
    {
        cdata.vehiculeDb vehiculedb = new cdata.vehiculeDb();
        List<cmetier.Vehicule> vehicules = new List<cmetier.Vehicule>();
        cdata.vehiculeDb vehicule_instance = new cdata.vehiculeDb();
        List<cmetier.Vehicule> list_vehicules = new List<cmetier.Vehicule>();
        List<cmetier.Vehicule> list_vehicules_used = new List<cmetier.Vehicule>();
        cdata.personnelDb personneldb = new cdata.personnelDb();
        cdata.serviceDb servicedb = new cdata.serviceDb();

        public void reading()
        {
            list_vehicules = vehicule_instance.getVehiculesUsed();

            foreach (cmetier.Vehicule vehicule in list_vehicules)
            {
                list_vehicules_used = vehicule_instance.getVehiculesById(vehicule.Id);

                foreach (cmetier.Vehicule vehicules_used in list_vehicules_used)
                {
                    dgv_vehicule.Rows.Add(vehicules_used.Id, vehicule.Imma, vehicules_used.Marque, vehicules_used.Modele, vehicules_used.Annee);
                }
            }

            List<cmetier.Service> list_services = new List<cmetier.Service>();
            list_services = servicedb.sendReqInfo();

            foreach (cmetier.Service service in list_services)
            {
                _combo_vehicule_affect_service.Items.Add(service.Type_service);
            }
            _combo_vehicule_affect_service.SelectedIndex = 0;

            List<cmetier.Personnel> list_personnels = new List<cmetier.Personnel>();
            MySqlDataReader personnel_reader = personneldb.getInfoSalarieService(_combo_vehicule_affect_service.SelectedItem.ToString());

            while (personnel_reader.Read())
            {
                string nom = personnel_reader.GetString(1);
                string prenom = personnel_reader.GetString(1);
                int id = personnel_reader.GetInt32(0);

                cmetier.Personnel perso = new cmetier.Personnel(id, nom, prenom, 0, "", "", 0, 0, "");
                list_personnels.Add(perso);
            }

            personnel_reader.Close();
        }

        public formVehiculeMarque()
        {
            InitializeComponent();
            button_vehicule_annuler.red = true;
            button_vehicule_affect.blue = true;
            vehicules = vehiculedb.sendReqInfo();
            reading();

        }

        private void button_vehicule_modifier_Click(object sender, EventArgs e)
        {
           
        }

        private void formVehiculeMarque_Load(object sender, EventArgs e)
        {

        }

        private void button_vehicule_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_vehicule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _combo_vehicule_affect_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<cmetier.Personnel> list_personnels = new List<cmetier.Personnel>();
            MySqlDataReader personnel_reader = personneldb.getInfoSalarieService(_combo_vehicule_affect_service.SelectedItem.ToString());

            while (personnel_reader.Read())
            {
                string nom = personnel_reader.GetString(1);
                string prenom = personnel_reader.GetString(1);
                int id = personnel_reader.GetInt32(0);

                cmetier.Personnel perso = new cmetier.Personnel(id, nom, prenom, 0, "", "", 0, 0, "");
                list_personnels.Add(perso);
            }
            personnel_reader.Close();
        }

        private void button_vehicule_affect_Click(object sender, EventArgs e)
        {
            //Récupère la valeur de la cellule sélectionnée
            int ligneSelectionIndex = dgv_vehicule.SelectedCells[0].RowIndex;
            DataGridViewRow ligneSelection = dgv_vehicule.Rows[ligneSelectionIndex];
            string id_vehicule = Convert.ToString(ligneSelection.Cells[0].Value);

            string type_service = _combo_vehicule_affect_service.SelectedItem.ToString();
            bool affect_res = false;
            if (_vehicule_checkbox_affectresp.Checked)
            {
                affect_res = true;
            }            

            try
            {
                vehiculedb.setAffectVehiculeSalarieService(type_service, id_vehicule, affect_res);
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_vehicule_ajouter_Click(object sender, EventArgs e)
        {
            cvue.vVehicule.vAjout.formAjoutVehicule formAjoutVehicule = new vAjout.formAjoutVehicule();
            formAjoutVehicule.Show();
        }

        private void dgv_vehicule_SelectionChanged(object sender, EventArgs e)
        {
            //Récupère la valeur de la cellule sélectionnée
            int ligneSelectionIndex = dgv_vehicule.SelectedCells[0].RowIndex;
            DataGridViewRow ligneSelection = dgv_vehicule.Rows[ligneSelectionIndex];
            string id_vehicule = Convert.ToString(ligneSelection.Cells[0].Value);

            string type_service = vehiculedb.getVehiculeTypeService(id_vehicule);
            string nom_prenom = vehiculedb.getVehiculeSalarie(id_vehicule);

            infobar_vehicule.Text = "Service / Responsable : " + type_service + " / " + nom_prenom;
        }
    }

       
    }

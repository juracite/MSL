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

        public void reading()
        {
            list_vehicules = vehicule_instance.getVehiculesUsed();

            foreach (cmetier.Vehicule vehicule in list_vehicules)
            {
                list_vehicules_used = vehicule_instance.getVehiculesById(vehicule.Id);

                foreach (cmetier.Vehicule vehicules_used in list_vehicules_used)
                {
                    dgv_vehicule.Rows.Add(vehicules_used.Id, vehicules_used.Marque, vehicules_used.Modele, vehicules_used.Annee);
                }
            }
        }

        public formVehiculeMarque()
        {
            InitializeComponent();
            button_vehicule_annuler.red = true;
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
    }

       
    }

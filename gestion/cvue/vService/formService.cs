using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion.cvue.vService
{
    public partial class formService : Form
    {
        int id_salarie;
        string nom_salarie;
        string prenom_salarie;

        List<cmetier.Personnel> personnels = new List<cmetier.Personnel>();

        cdata.serviceDb service = new cdata.serviceDb();
        cdata.personnelDb persodb = new cdata.personnelDb();

        string[] splitted_id_resp;
        // Lit les données de la BDD & remplit tous les inputs
        private void reading()
        {
            try
            {
                List<cmetier.Service> list_typeService = service.sendReqInfo();
                foreach (cmetier.Service serv in list_typeService)
                {
                    dgv_service.Rows.Add(serv.Type_service, serv.Libelle_service);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
        public formService()
        {
            InitializeComponent();
            //alert_box_service.Visible = true;
            reading();
            button_service_supprimer.red = true;
            button_service_vue_ajout.blue = true;
        }

        private void checker_Tick(object sender, EventArgs e)
        {
            if (dgv_service.SelectedCells.Count > 0)
            {
                button_service_supprimer.Enabled = true;
            }
        }

		void Button_service_vue_ajoutClick(object sender, EventArgs e)
		{
			vAjout.formAddService formAddService = new vAjout.formAddService();
            formAddService.Show();
		}

        
        private void dgv_service_SelectionChanged(object sender, EventArgs e)
        {
            //Récupère la valeur de la cellule sélectionnée
            int ligneSelectionIndex = dgv_service.SelectedCells[0].RowIndex;
            DataGridViewRow ligneSelection = dgv_service.Rows[ligneSelectionIndex];
            string a = Convert.ToString(ligneSelection.Cells[0].Value);
            cmetier.Personnel responsable;

            //Vide la combo_box
            combo_service_responsable.Items.Clear();

            /// <summary>
            /// Méthode de récupération des informations du salarie par rapport au type de service (dans la BDD)
            /// </summary>
            /// <param name="a">type de service</param>
            try
            {
                personnels = persodb.getSalarieTypeService(a);
                for (int i = 0; i < personnels.Count(); i++)
                {
                    id_salarie = personnels[i].Id_salarie;
                    nom_salarie = personnels[i].Nom;
                    prenom_salarie = personnels[i].Prenom;
                    combo_service_responsable.Items.Add(Convert.ToString(id_salarie) + " - " + nom_salarie + " - " + prenom_salarie);
                }
                personnels.Clear();
                if (combo_service_responsable.Items.Count > 0)
                {
                    combo_service_responsable.SelectedIndex = 0;
                }
                responsable = persodb.getResponsableTypeService(a);
                string responsable_nom = responsable.Nom;
                string responsable_prenom = responsable.Prenom;
                status_bar_service.Text = "Responsable : " + responsable_nom + " - " + responsable_prenom;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            int ligneSelectionIndex = dgv_service.SelectedCells[0].RowIndex;
            DataGridViewRow ligneSelection = dgv_service.Rows[ligneSelectionIndex];
            string a = Convert.ToString(ligneSelection.Cells[0].Value);

            cmetier.Personnel responsable;
            splitted_id_resp = combo_service_responsable.SelectedItem.ToString().Split('-');

            string id_new_responsable = splitted_id_resp[0].ToString();

            responsable = persodb.getResponsableTypeService(a);
            persodb.updateResponsableTypeService(responsable, id_new_responsable);
            responsable = persodb.getResponsableTypeService(a);

            string responsable_nom = responsable.Nom;
            string responsable_prenom = responsable.Prenom;
            status_bar_service.Text = "Responsable : " + responsable_nom + " - " + responsable_prenom;
        }

        private void combo_service_responsable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

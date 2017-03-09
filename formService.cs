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
        List<int> id_salarie_service = new List<int>();
    	List<string> type_service = new List<string>();
    	List<string> nom_responsables = new List<string>();
        List<string> id_responsables = new List<string>();
        string[] splitted_id_resp;
        private void reading()
        {
            cmetier.Service service = new cmetier.Service();
            MySqlDataReader reader_typeService = service.sendReqInfo();
            while (reader_typeService.Read())
            {
                type_service.Add(reader_typeService.GetString(0));
                //dgv_service.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            reader_typeService.Close();

            

            MySqlDataReader reader_nom;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            for (int i = 0; i < type_service.Count(); i++)
            {
                string req = "SELECT DISTINCT id_salarie, nom, prenom FROM salarie WHERE type_service='" + type_service[i] + "'";
                cmd.CommandText = req;
                reader_nom = cmd.ExecuteReader();
                while (reader_nom.Read())
                {
                    nom_responsables.Add(reader_nom.GetString(1));
                    id_responsables.Add(reader_nom.GetString(0));
                }
                reader_nom.Close();
            }

            MySqlDataReader reader = service.sendReqInfo();
            int cpt = 0;
            int cpt_resp = nom_responsables.Count();
            while (reader.Read())
            {
                dgv_service.Rows.Add(reader.GetString(0), reader.GetString(1));
                if (cpt < cpt_resp)
                {
                    //nom_responsable.Items.Add(nom_responsables[cpt]);
                }
                cpt++;
            }
            reader.Close();
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

            int ligneSelectionIndex = dgv_service.SelectedCells[0].RowIndex;
            DataGridViewRow ligneSelection = dgv_service.Rows[ligneSelectionIndex];
            string a = Convert.ToString(ligneSelection.Cells[0].Value);

            combo_service_responsable.Items.Clear();

            string req;
            MySqlDataReader reader_nom;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            req = "SELECT prenom, nom, id_salarie FROM salarie WHERE type_service='" + a + "'";
            cmd.CommandText = req;
            reader_nom = cmd.ExecuteReader();
            while (reader_nom.Read())
            {
                combo_service_responsable.Items.Add(reader_nom.GetString(0) + " " + reader_nom.GetString(1) + "-" + reader_nom.GetInt16(2));
                id_salarie_service.Add(reader_nom.GetInt16(2));
            }
            reader_nom.Close();

            req = "SELECT prenom, nom FROM salarie WHERE type_service='" + a + "' AND responsable=1";
            cmd.CommandText = req;
            reader_nom = cmd.ExecuteReader();
            string prenom_responsable;
            string nom_responsable;
            if (reader_nom.Read())
            {
                prenom_responsable = reader_nom.GetString(0);
                nom_responsable = reader_nom.GetString(1);
                status_bar_service.Text = "Responsable : " + prenom_responsable + " " + nom_responsable;
                combo_service_responsable.SelectedIndex = 0;
            }
            else
            {
            	reader_nom.Close();
            	req = "SELECT prenom, nom, id_salarie FROM salarie";
	            cmd.CommandText = req;
	            reader_nom = cmd.ExecuteReader();
	            while (reader_nom.Read())
	            {
	                combo_service_responsable.Items.Add(reader_nom.GetString(0) + " " + reader_nom.GetString(1) + "-" + reader_nom.GetInt16(2));
	                id_salarie_service.Add(reader_nom.GetInt16(2));
	            }
	            reader_nom.Close();
                status_bar_service.Text = "Responsable : INCONNU";
            }
            reader_nom.Close();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            int ligneSelectionIndex = dgv_service.SelectedCells[0].RowIndex;
            DataGridViewRow ligneSelection = dgv_service.Rows[ligneSelectionIndex];
            string a = Convert.ToString(ligneSelection.Cells[0].Value);

            int selected_resp = combo_service_responsable.SelectedIndex;

            string req;
            string id_resp_act;
            int found_id_resp;
            MySqlDataReader reader_salarie;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            req = "SELECT id_salarie FROM salarie WHERE type_service='" + a + "' AND responsable=1";
            cmd.CommandText = req;
            reader_salarie = cmd.ExecuteReader();

            splitted_id_resp = combo_service_responsable.SelectedItem.ToString().Split('-');

            if (reader_salarie.Read())
            {
                id_resp_act = reader_salarie.GetString(0);

                reader_salarie.Close();
                req = "UPDATE salarie SET responsable='0' WHERE id_salarie='" + id_resp_act + "'";
                cmd.CommandText = req;
                reader_salarie = cmd.ExecuteReader();
                reader_salarie.Close();

                req = "UPDATE salarie SET responsable='1' WHERE id_salarie='" + splitted_id_resp[1].ToString() + "'";
                cmd.CommandText = req;
                reader_salarie = cmd.ExecuteReader();
            }
            else
            {
                reader_salarie.Close();
                req = "UPDATE salarie SET responsable=1 WHERE id_salarie='" + splitted_id_resp[1].ToString() + "'";
                cmd.CommandText = req;
                reader_salarie = cmd.ExecuteReader();
            }
            reader_salarie.Close();

            
        }

        private void combo_service_responsable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion.cvue.vPersonnel
{
    public partial class formPersonnel : Form
    {

        private void reading()
        {
            cdata.personnelDb personnel = new cdata.personnelDb();
            List<cmetier.Personnel> list_personnel = personnel.sendReqInfo();
            dgv_personnel.Rows.Clear();
           foreach(cmetier.Personnel pers in list_personnel)
            {
                dgv_personnel.Rows.Add(pers.Id_salarie, pers.Nom, pers.Prenom, pers.Type_service, pers.Mail);
            }
        }
        public formPersonnel()
        {
            InitializeComponent();
            button_personnel_delete.red = true;
            button_personnel_vue_ajouter.blue = true;
            reading();
        }

        private void formPersonnel_Load(object sender, EventArgs e)
        {

        }
		void Button_personnel_deleteClick(object sender, EventArgs e)
		{
            cdata.personnelDb personnel = new cdata.personnelDb();

			int selectedrowindex = dgv_personnel.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgv_personnel.Rows[selectedrowindex];

            string id = Convert.ToString(selectedRow.Cells[0].Value);

            personnel.deleteSalarie(id);


            reading();
		}
		void Button_personnel_vue_ajouterClick(object sender, EventArgs e)
		{
			vAjout.formAddPersonnel formAddPersonnel = new vAjout.formAddPersonnel();
            formAddPersonnel.Show();
		}

        private void button_personnel_modify_Click(object sender, EventArgs e)
        {
            //Récupère la valeur de la cellule sélectionnée
            int ligneSelectionIndex = dgv_personnel.SelectedCells[0].RowIndex;
            DataGridViewRow ligneSelection = dgv_personnel.Rows[ligneSelectionIndex];

            string id = Convert.ToString(ligneSelection.Cells[0].Value);
            string nom = Convert.ToString(ligneSelection.Cells[1].Value);
            string prenom = Convert.ToString(ligneSelection.Cells[2].Value);
            string mail = Convert.ToString(ligneSelection.Cells[4].Value);

            vModif.formModifPersonnel formModifPersonnel = new vModif.formModifPersonnel(id, nom, prenom, mail);
            formModifPersonnel.Show();
        }

        private void formPersonnel_Enter(object sender, EventArgs e)
        {
        }

        private void formPersonnel_Activated(object sender, EventArgs e)
        {
        }

        private void dgv_personnel_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

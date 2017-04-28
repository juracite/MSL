using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion.cvue.vService.vAjout
{
    public partial class formAddService : Form
    {
    	cdata.serviceDb service = new cdata.serviceDb();
    	cdata.personnelDb personnel = new cdata.personnelDb();
    	List<string> type_service = new List<string>();
    	
        private List<string> reading()
        {
            List<cmetier.Service> list_service = service.sendReqInfo();
            foreach(cmetier.Service serv in list_service)
            {
                combo_service_type.Items.Add(serv.Type_service);
                combo_service_type.Text = serv.Type_service;
            }

            List<cmetier.Personnel> list_personnel = personnel.sendReqInfo();
            foreach (cmetier.Personnel pers in list_personnel)
            {
            	type_service.Add(pers.Type_service);
            }
            return type_service;
        }
        public formAddService()
        {
            InitializeComponent();
            reading();
        }

        private void butt_service_close_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void butt_service_create_Click(object sender, EventArgs e)
        {
            try
            {
                string nom_service = _service_nomService.Text;
                string type_service = combo_service_type.SelectedItem.ToString();
                MessageBox.Show(type_service);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
		void Button_service_vue_ajout_annulerClick(object sender, EventArgs e)
		{
            Close();
		}
		void Button_service_vue_ajout_ajouterClick(object sender, EventArgs e)
		{
			string service_type = combo_service_type.Text;
			string service_nom = _service_nomService.Text;
			
			MySqlDataReader reader_service_libelle = service.getServiceLibelle(service_type);
			if(reader_service_libelle.Read()){
				string libelle_service = reader_service_libelle.GetString(0);
				reader_service_libelle.Close();
				service.updateService(service_type, libelle_service+","+service_nom);
			}
			else{
				reader_service_libelle.Close();
				service.setService(service_type, _service_nomService.Text);
			}

            Close();
			formService.ActiveForm.Close();
			formService formServ = new formService();
			formServ.Show();
			
		}

        private void formAddService_Load(object sender, EventArgs e)
        {

        }
    }
}

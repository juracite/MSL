using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion.cvue.vPersonnel.vAjout
{
    public partial class formAddPersonnel : Form
    {
        cdata.serviceDb service_instance = new cdata.serviceDb();
    	cdata.personnelDb personnel_instance = new cdata.personnelDb();
        cdata.vehiculeDb vehicule_instance = new cdata.vehiculeDb();
        List<cmetier.Vehicule> list_vehicules = new List<cmetier.Vehicule>();
        cmetier.Vehicule vehicule_used;

        string marque = "";
        string modele = "";

        public void reading()
        {
            List<cmetier.Service> list_service = service_instance.sendReqInfo();
            foreach (cmetier.Service serv in list_service)
            {
                combo_personnel_service.Items.Add(serv.Type_service);
                combo_personnel_service.Text = serv.Type_service;
            }

            //List<cmetier.Vehicule> list_vehicule_marque = vehicule_instance.getDisctinctVehiculesMarque();
            //foreach (cmetier.Vehicule vehicule in list_vehicule_marque)
            //{
            //    combo_personnel_marque.Items.Add(vehicule.Marque);
            //    combo_personnel_marque.Text = vehicule.Marque;
            //}
            //List<cmetier.Vehicule> list_vehicule_modele = vehicule_instance.getDistinctVehiculesModele(marque);
            //foreach (cmetier.Vehicule vehicule in list_vehicule_modele)
            //{
            //    combo_personnel_modele.Items.Add(vehicule.Modele.ToString());
            //    combo_personnel_modele.Text = vehicule.Modele.ToString();
            //}
            //marque = combo_personnel_marque.Text;

            list_vehicules = vehicule_instance.getVehiculesUsed();

            foreach(cmetier.Vehicule vehicule in list_vehicules)
            {
                vehicule_used = vehicule_instance.getVehiculeById(vehicule.Id);
                combo_personnel_vehicule.Items.Add(vehicule_used.Id+"-"+ vehicule_used.Marque+"-"+ vehicule_used.Modele+"-"+ vehicule_used.Annee);
                combo_personnel_vehicule.Text = vehicule_used.Id + "-" + vehicule_used.Marque + "-" + vehicule_used.Modele + "-" + vehicule_used.Annee;
            }
        }

        public formAddPersonnel()
        {
            InitializeComponent();
            button_personnel_annuler.red = true;
            reading();
        }
		void FormAddPersonnelLoad(object sender, EventArgs e)
		{
	
		}
		void Button_personnel_ajouterClick(object sender, EventArgs e)
		{
            try
            {
                string[] str_split = combo_personnel_vehicule.Text.Split('-');
                personnel_instance.ajouterSalarie(_personnel_nom.Text, _personnel_prenom.Text, _personnel_mobile.Text, combo_personnel_service.Text, _personnel_mail.Text, Convert.ToInt32(str_split[0]), _personnel_login.Text, _personnel_password.Text);
                ActiveForm.Close();
                formPersonnel.ActiveForm.Close();
                formPersonnel formPers = new formPersonnel();
                //ActiveForm.Close();
                formPers.Show();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}
		void Button_personnel_annulerClick(object sender, EventArgs e)
		{
			ActiveForm.Close();
		}

        private void combo_personnel_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            //marque = combo_personnel_marque.Text;
            //List<cmetier.Vehicule> list_vehicule_modele = vehicule_instance.getDistinctVehiculesModele(marque);
            //combo_personnel_modele.Items.Clear();
            //foreach (cmetier.Vehicule vehicule in list_vehicule_modele)
            //{
            //    combo_personnel_modele.Items.Add(vehicule.Modele.ToString());
            //    combo_personnel_modele.Text = vehicule.Modele.ToString();
            //}
        }

        private void combo_personnel_annee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_personnel_modele_SelectedIndexChanged(object sender, EventArgs e)
        {
            //modele = combo_personnel_modele.Text;
            //List<cmetier.Vehicule> list_vehicule_annee = vehicule_instance.getDistinctVehiculesAnnee(marque, modele);
            //combo_personnel_annee.Items.Clear();
            //foreach (cmetier.Vehicule vehicule in list_vehicule_annee)
            //{
            //    combo_personnel_annee.Items.Add(vehicule.Annee.ToString());
            //    combo_personnel_annee.Text = vehicule.Annee.ToString();
            //}
        }
    }
}
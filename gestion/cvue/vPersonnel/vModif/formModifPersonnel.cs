using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion.cvue.vPersonnel.vModif
{
    public partial class formModifPersonnel : Form
    {
        cdata.serviceDb service = new cdata.serviceDb();
        cdata.personnelDb personnel = new cdata.personnelDb();

        private string nom;
        private string prenom;
        private string mail;
        private string id;

        public formModifPersonnel(string id, string nom, string prenom, string mail)
        {
            InitializeComponent();
            button_personnel_annuler.red = true;

            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.id = id;
        }

        private void formModifPersonnel_Load(object sender, EventArgs e)
        {
            _personnel_nom.Text = nom;
            _personnel_prenom.Text = prenom;
            _personnel_mail.Text = mail;

            List<cmetier.Service> list_service = service.sendReqInfo();
            foreach (cmetier.Service serv in list_service)
            {
                combo_personnel_service.Items.Add(serv.Type_service);
                combo_personnel_service.Text = serv.Type_service;
            }
        }

        private void button_personnel_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_personnel_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                personnel.updateSalarie(id, _personnel_nom.Text, _personnel_prenom.Text, _personnel_mail.Text, combo_personnel_service.Text);
                Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

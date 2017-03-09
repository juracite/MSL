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

        public void reading()
        {
            List<cmetier.Vehicule> list_vehicules = new List<cmetier.Vehicule>();
            list_vehicules = vehiculedb.getDisctinctVehiculesMarque();

            foreach(cmetier.Vehicule vehicule in list_vehicules)
            {
                _affect_marque.Items.Add(vehicule.Marque);
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
    }
}

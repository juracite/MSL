using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion.cvue.vVehicule.vListeEntretien
{
    public partial class formEntretienListe : Form
    {
        public formEntretienListe()
        {
            InitializeComponent();
            button_entretien_annuler.red = true;
        }

        private void button_entretien_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_entretien_rdv_Click(object sender, EventArgs e)
        {
            vRdv.formRendezvous formRdv = new vRdv.formRendezvous();
            formRdv.Show();
        }
    }
}

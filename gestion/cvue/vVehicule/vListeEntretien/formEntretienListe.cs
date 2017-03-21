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
        cdata.entretienDb entretiendb = new cdata.entretienDb();

        public void reading()
        {
            List<cmetier.Entretien> list_entretien = new List<cmetier.Entretien>();
            try
            { 
                list_entretien = entretiendb.sendReqInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            foreach(cmetier.Entretien entretien in list_entretien)
            {
                dgv_entretien.Rows.Add(entretien.Id, entretien.Imma);
            }
        }

        public formEntretienListe()
        {
            InitializeComponent();
            button_entretien_annuler.red = true;
            reading();
            
        }

        private void button_entretien_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_entretien_rdv_Click(object sender, EventArgs e)
        {
            vRdv.formRendezvous formRdv = new vRdv.formRendezvous();
            formRdv.Show();
        }
    }
}

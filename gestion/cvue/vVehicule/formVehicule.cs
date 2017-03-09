using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion.cvue.vVehicule
{
    public partial class formVehicule : Form
    {
        public formVehicule()
        {
            InitializeComponent();
        }

        private void button_vehicule_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

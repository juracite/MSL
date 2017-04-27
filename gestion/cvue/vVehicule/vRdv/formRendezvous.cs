using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion.cvue.vVehicule.vRdv
{
    public partial class formRendezvous : Form
    {
        private List<cmetier.EntretienType> listeEnTypes = new List<cmetier.EntretienType>();

        public formRendezvous(List<cmetier.EntretienType> listeEnTypes)
        {

            InitializeComponent();
            this.listeEnTypes = listeEnTypes;

        }

        public void reading()
        {

        }


        private void formRendezvous_Load(object sender, EventArgs e)
        {
            button_reset.blue = true;
            button_supprimer.red = true;
            track_heure.Minimum = 8;
            track_minute.Minimum = 0;
            label_heure_minute.Text = track_heure.Value + " H " + track_minute.Value;
        }

        private void track_heure_Scroll(object sender)
        {
            label_heure_minute.Text = track_heure.Value + " H " + track_minute.Value;
        }

        private void track_minute_Scroll(object sender)
        {
            label_heure_minute.Text = track_heure.Value + " H " + track_minute.Value;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            string date = date_rdv.Text;
            string heure = label_heure_minute.Text;
            string commentaires = comm_rdv.Text;
            
        }
    }
}

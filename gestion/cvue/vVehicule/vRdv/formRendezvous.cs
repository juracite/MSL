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
        private string immat;
        private cdata.rdvEntretienDb rdvEntretienDb = new cdata.rdvEntretienDb();
        private cdata.vehiculeDb vehiculeDb = new cdata.vehiculeDb();

        public formRendezvous(List<cmetier.EntretienType> listeEnTypes, string immat)
        {

            InitializeComponent();
            this.listeEnTypes = listeEnTypes;
            this.immat = immat;

        }

        public void reading()
        {
            int cardinal = rdvEntretienDb.getLesRdvEntretien().Count;
            dgv_rdv.Rows.Clear();
            for (int i = 0; i < cardinal; i++)
            {
                dgv_rdv.Rows.Add(rdvEntretienDb.getLesRdvEntretien()[i].getImma(),
                    rdvEntretienDb.getLesRdvEntretien()[i].getDate(),
                    rdvEntretienDb.getLesRdvEntretien()[i].getHeure(),
                    rdvEntretienDb.getLesRdvEntretien()[i].getCommentaire(),
                    vehiculeDb.sendReqInfo()[i].Imma);
            }

            int lastEnt = rdvEntretienDb.getMaxIdRdvEnType();
            for (int j = 0; j < list_typeEnt.Items.Count; j++)
            {
                rdvEntretienDb.ajouterRdvEntretienType(lastEnt, list_typeEnt.Items[j].ToString().Split('-')[0]);
            }
        }


        private void formRendezvous_Load(object sender, EventArgs e)
        {
            button_reset.red = true;
            button_supprimer.red = true;
            button_quit.red = true;
            track_heure.Minimum = 8;
            track_minute.Minimum = 0;
            label_heure_minute.Text = track_heure.Value + " H " + track_minute.Value;
            reading();
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
            string immat = this.immat;
            try
            {
                rdvEntretienDb.ajouterRdvEntretien(date, heure, commentaires, immat);

                button_supprimer.Enabled = false;
                button_supprimer.Visible = false;

                button_quit.Enabled = true;
                button_quit.Visible = true;

                tc_rdv.SelectedTab = tp_listrdv;

                ((Control)this.tp_rdv).Enabled = false;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            int lastEnt = rdvEntretienDb.getMaxIdRdvEnType();

            for (int j = 0; j < list_typeEnt.Items.Count; j++)
            {
                rdvEntretienDb.ajouterRdvEntretienType(lastEnt, list_typeEnt.Items[j].ToString().Split('-')[0]);
            }
            reading();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            vListeEntretien.formEntretienListe formEnt = new vListeEntretien.formEntretienListe();
            formEnt.Show();
            Close();
        }
    }
}

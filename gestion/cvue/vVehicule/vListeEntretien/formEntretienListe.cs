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
        Dictionary<cmetier.Vehicule, List<cmetier.EntretienType>> dicoEntypeParVehicule = new Dictionary<cmetier.Vehicule, List<cmetier.EntretienType>>();

        List<cmetier.Vehicule> vehicules_utilises = new List<cmetier.Vehicule>();
        List<cmetier.EntretienType> entretiens_type = new List<cmetier.EntretienType>();

        cdata.vehiculeDb vehiculeDb = new cdata.vehiculeDb();
        cdata.EntretienTypeDb entDb = new cdata.EntretienTypeDb();
        cdata.rdvEntretienDb rdvEntDb = new cdata.rdvEntretienDb();

        public void reading()
        {
            vehicules_utilises = vehiculeDb.getVehiculesUsed();
            entretiens_type = entDb.getLesTypeEntretien();

            foreach (cmetier.Vehicule unVehicule in vehicules_utilises)
            {
                List<cmetier.EntretienType> lesEntretiensTypes = new List<cmetier.EntretienType>();

                int KmVoiture = unVehicule.NbKmCompteur;
                int KmEntretien = unVehicule.NbKmDernierEnt;
                int diffKm = KmVoiture - KmEntretien;

                foreach (cmetier.EntretienType unEnType in entretiens_type)
                {
                    if (diffKm >= unEnType.getNbKm())
                    {
                        lesEntretiensTypes.Add(unEnType);
                    }
                }
                if (lesEntretiensTypes.Count() > 0)
                {
                    dicoEntypeParVehicule.Add(unVehicule, lesEntretiensTypes);
                }
            }

            //listage du dictionnaire : remplissage du datagridview
            foreach (KeyValuePair<cmetier.Vehicule, List<cmetier.EntretienType>> pairVehiculeEnt in dicoEntypeParVehicule)
            {
                if (rdvEntDb.getRdvExist(pairVehiculeEnt.Key.Id) == 0)
                {
                    dgv_entretien.Rows.Add(pairVehiculeEnt.Key.Id, pairVehiculeEnt.Key.Imma, "Pas de rendez-vous");
                }
                else
                {
                    dgv_entretien.Rows.Add(pairVehiculeEnt.Key.Id, pairVehiculeEnt.Key.Imma, "RDV en cours");
                    int line = dgv_entretien.CurrentCell.RowIndex;
                    dgv_entretien.Rows[line].Visible = false;

                }

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
            int id = int.Parse(this.dgv_entretien.CurrentRow.Cells[0].Value.ToString());
            cmetier.Vehicule unVehicule = vehiculeDb.getVehiculeById(id);
            List<cmetier.EntretienType> listeEnTypes = new List<cmetier.EntretienType>();
            try
            {
                listeEnTypes = dicoEntypeParVehicule[unVehicule];
            }
            catch (KeyNotFoundException ex)
            {
                foreach (KeyValuePair<string, string> item in ex.Data)
                    Console.WriteLine("Key not found (Key = {0} ; value = {1})",
                        item.Key, item.Value);
            }
            vRdv.formRendezvous fre = new vRdv.formRendezvous(listeEnTypes);
            fre.ShowDialog();
        }

        private void dgv_entretien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(this.dgv_entretien.CurrentRow.Cells[0].Value.ToString());
            if(id == 0)
            {
                MessageBox.Show(id.ToString());
            }
            else
            {
                MessageBox.Show(id.ToString());
            }
        }

        private void formEntretienListe_Load(object sender, EventArgs e)
        {

        }

        private void dgv_entretien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.dgv_entretien.CurrentRow.Cells[0].Value.ToString());
                button_entretien_rdv.Enabled = true;
                button_entretien_rdv.Visible = true;
            }
            catch
            {
                button_entretien_rdv.Enabled = false;
                button_entretien_rdv.Visible = false;
            }
        }
    }
}

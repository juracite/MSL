using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using gestion.cdata;
using gestion.cmetier;
using gestion;

namespace gestion.cdata
{
    class rdvEntretienDb
    {
        //AJOUTER RDVENTRETIEN
        public void ajouterRdvEntretien(string date, string heure, string commentaire, int idVehicule)
        {
            try
            {
                string sql = "INSERT INTO rdventretien (date, heure, commentaire, id_Vehicule) VALUES('" + date + "','" + heure + "','" + commentaire + "','" + idVehicule + "')";
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                cmdSql.ExecuteNonQuery();
                MessageBox.Show("Enregistrement ajouté");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //RECUPERER ID DERNIER ENTRETIEN
        public int getMaxIdRdvEnType()
        {
            //try
            //{
            string sql = "SELECT MAX(id) FROM rdventretien";
            MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
            cmdSql.CommandText = sql;
            MySqlDataReader resultat = cmdSql.ExecuteReader();
            resultat.Read();
            int id = Convert.ToInt32(resultat.GetValue(0));
            resultat.Close();
            //}
            //catch (MySqlException ex)
            //{
            //MessageBox.Show(ex.Message.ToString());
            //}
            return id;
        }
        //MODIFIER RDVENTRETIEN
        public void modifierRdvEntretien(int id, string date, string heure, string commentaire, int idVehicule, int idEntretienType)
        {
            try
            {
                string sql = "UPDATE rdventretien SET date='" + date + "',heure='" + heure + "', commentaire='" + commentaire + "', id_Vehicule='" + idVehicule + "', id_EntretienType=" + idEntretienType + " WHERE id=" + id;
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                cmdSql.ExecuteNonQuery();
                MessageBox.Show("Modification enregistrée");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //SUPPRIMER RDVENTRETIEN
        public void supprimerRdvEntretien(int id)
        {
            try
            {
                string sql = "DELETE * FROM rdventretien WHERE id=" + id;
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                cmdSql.ExecuteNonQuery();
                MessageBox.Show("Suppression effectuée");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //LISTE DES RDVENTRETIEN
        public List<rdvEntretien> getLesRdvEntretien()
        {
            List<cmetier.rdvEntretien> lesRdvEntretien = new List<cmetier.rdvEntretien>();
            rdvEntretien rE;
            try
            {
                string sql = "SELECT * FROM rdventretien";
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                MySqlDataReader resultat = cmdSql.ExecuteReader();
                while (resultat.Read())
                {
                    int id = Convert.ToInt32(resultat.GetValue(0));
                    string date = resultat.GetValue(1).ToString();
                    string heure = resultat.GetValue(2).ToString();
                    string commentaire = resultat.GetValue(3).ToString();
                    int idVehicule = Convert.ToInt32(resultat.GetValue(4));
                    rE = new rdvEntretien(id, date, heure, commentaire, idVehicule);
                    lesRdvEntretien.Add(rE);
                }
                resultat.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return lesRdvEntretien;
        }
        //AJOUTER RDV ENTRTETIEN TYPE
        public void ajouterRdvEntretienType(int idRdv, string idEntType)
        {
            try
            {
                int idEntretienType = Convert.ToInt32(idEntType);
                string sql = "INSERT INTO rdventretientype (idRdv, idEntretienType) VALUES( " + idRdv + ", " + idEntretienType + ")";
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                cmdSql.ExecuteNonQuery();
                //MessageBox.Show("Suppression effectuée");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //TEST SI LE RDV EST PRIS
        public int getRdvExist(int idVehicule)
        {

            //try
            //{
            string sql = "SELECT COUNT(*) FROM rdventretien WHERE id_vehicule=" + idVehicule;
            MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
            cmdSql.CommandText = sql;
            MySqlDataReader resultat = cmdSql.ExecuteReader();
            resultat.Read();
            int nbId = Convert.ToInt32(resultat.GetValue(0));
            resultat.Close();
            //}
            // catch (MySqlException ex)
            // {
            //MessageBox.Show(ex.Message.ToString());
            //}
            return nbId;
        }
    }
}
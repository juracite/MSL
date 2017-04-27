using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cdata
{
    class entretienDb
    {
        public static void ajouterEntretien(string uneDateEntretien, int unNbKmCompteur, string unCommentaire, int unIdVehicule, int unIdEntretienType)
        {
            try
            {
                string sql = "INSERT INTO entretien (dateEntretien, nbKmCompteur, commentaire) VALUES('" + uneDateEntretien + "','" + unNbKmCompteur + "','" + unCommentaire + "')";
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                cmdSql.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void modifierEntretien(int idEntretien, string uneDateEntretien, int unNbKmCompteur, string unCommentaire, int unIdVehicule, int unIdEntretienType)
        {
            try
            {
                string sql = "UPDATE entretien SET dateEntretien='" + uneDateEntretien + "',nbKmCompteur='" + unNbKmCompteur + "', commentaire='" + unCommentaire + "' WHERE id_entretien=" + idEntretien;
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                cmdSql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void supprimerEntretien(int idEntretien)
        {
            try
            {
                string sql = "DELETE * FROM entretien WHERE idEntretien=" + idEntretien;
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                cmdSql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static List<cmetier.Entretien> ListerEntretien()
        {
            List<cmetier.Entretien> listEntretien = new List<cmetier.Entretien>();
            try
            {
                cmetier.Entretien entretien;

                string sql = "SELECT * FROM entretien";
                MySqlCommand cmdSql = form_gestion.instance.CreateCommand();
                cmdSql.CommandText = sql;
                MySqlDataReader resultat = cmdSql.ExecuteReader();
                while (resultat.Read())
                {
                    entretien = new cmetier.Entretien(Convert.ToInt32(resultat.GetValue(0)), resultat.GetValue(1).ToString(), Convert.ToInt32(resultat.GetValue(2)), resultat.GetValue(3).ToString(), resultat.GetValue(4).ToString(), Convert.ToInt32(resultat.GetValue(6)));
                    listEntretien.Add(entretien);
                }
                resultat.Close();

                return listEntretien;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return listEntretien;
            }
        }
    }
}

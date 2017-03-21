using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cdata
{
    class entretienDb
    {
        public List<cmetier.Entretien> sendReqInfo()
        {
            string req = "select * from vehicules";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Entretien entretien;
            List<cmetier.Entretien> list_entretien = new List<cmetier.Entretien>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string imma = reader.GetString(1);
                DateTime dateAchat = reader.GetDateTime(2);
                int nbKmCompteur = reader.GetInt32(3);
                string motorisation = reader.GetString(4);
                int idModele = reader.GetInt32(5);
                int idSalarie = reader.GetInt32(6);
                int nbKmLastEnt = reader.GetInt32(7);

                entretien = new cmetier.Entretien(id, nbKmCompteur, nbKmLastEnt, 0, 0, "", "", imma, dateAchat, dateAchat, dateAchat);
                list_entretien.Add(entretien);
            }
            reader.Close();
            return list_entretien;
        }
    }
}

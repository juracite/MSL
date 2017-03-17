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
            cmetier.Personnel personnel;
            List<cmetier.Personnel> list_personnel = new List<cmetier.Personnel>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string imma = reader.GetString(1);
                string dateAchat = reader.GetString(2);
                int nbKmCompteur = reader.GetInt32(3);
                string motorisation = reader.GetString(4);
                int idModele = reader.GetInt32(5);
                int idSalarie = reader.GetInt32(6);
                int nbKmLastEnt = reader.GetInt32(7);

                personnel = new cmetier.Entretien();
                list_personnel.Add(personnel);
            }
            reader.Close();
            return list_personnel;
        }
    }
    }
}

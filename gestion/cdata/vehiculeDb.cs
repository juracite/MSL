using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cdata
{
    class vehiculeDb
    {
        public List<cmetier.Vehicule> sendReqInfo()
        {
            string req = "select * from marque_modele";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Vehicule vehicule;
            List<cmetier.Vehicule> list_vehicule = new List<cmetier.Vehicule>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int annee = reader.GetInt32(1);
                string marque = reader.GetString(2);
                string modele = reader.GetString(3);

                vehicule = new cmetier.Vehicule(id, annee, marque, modele, "");
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }

        public List<cmetier.Vehicule> getVehiculesById(int id)
        {
            string req = "select * from marque_modele where id='"+ id +"'";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Vehicule vehicule;
            List<cmetier.Vehicule> list_vehicule = new List<cmetier.Vehicule>();
            while (reader.Read())
            {
                int id_vehicule = reader.GetInt32(0);
                int annee = reader.GetInt32(1);
                string marque = reader.GetString(2);
                string modele = reader.GetString(3);

                vehicule = new cmetier.Vehicule(id_vehicule, annee, marque, modele, "");
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }

        public List<cmetier.Vehicule> getDisctinctVehiculesMarque()
        {
            string req = "select DISTINCT(marque) from marque_modele";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Vehicule vehicule;
            List<cmetier.Vehicule> list_vehicule = new List<cmetier.Vehicule>();
            while (reader.Read())
            {
                string marque = reader.GetString(0);

                vehicule = new cmetier.Vehicule(0, 0, marque, "", "");
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }

        public List<cmetier.Vehicule> getDistinctVehiculesModele(string marque)
        {
            List<cmetier.Vehicule> list_vehicule = new List<cmetier.Vehicule>();
            string req = "select DISTINCT(modele) from marque_modele where marque='" + marque + "'";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Vehicule vehicule;

            while (reader.Read())
            {
                string modele = reader.GetString(0);

                vehicule = new cmetier.Vehicule(0, 0, "", modele, "");
                list_vehicule.Add(vehicule);
            }
            reader.Close();

            return list_vehicule;
        }

        public List<cmetier.Vehicule> getDistinctVehiculesAnnee(string marque, string modele)
        {
            List<cmetier.Vehicule> list_vehicule = new List<cmetier.Vehicule>();
            string req = "select annee from marque_modele where marque='" + marque + "' AND modele='" + modele + "'";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Vehicule vehicule;

            while (reader.Read())
            {
                int annee = reader.GetInt16(0);

                vehicule = new cmetier.Vehicule(0, annee, "", "", "");
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }

        public List<cmetier.Personnel> getAllSalarieVehicule()
        {
            string req = "SELECT * FROM salarie WHERE immatriculation!=''";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Personnel salarie;
            List<cmetier.Personnel> list_salarie = new List<cmetier.Personnel>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nom = reader.GetString(1);
                string prenom = reader.GetString(2);
                int mobile = reader.GetInt32(3);
                string type_service = reader.GetString(4);
                string mail = reader.GetString(5);
                int responsable = reader.GetInt32(6);
                int id_vehicule = reader.GetInt32(7);
                string immatriculation = reader.GetString(8);

                salarie = new cmetier.Personnel(id, nom, prenom, mobile, type_service, mail, responsable, id_vehicule, immatriculation);
                list_salarie.Add(salarie);
            }
            reader.Close();
            return list_salarie;
        }
        public List<cmetier.Vehicule> getVehiculesUsed()
        {
            string req = "select * from vehicules";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Vehicule vehicule;
            List<cmetier.Vehicule> list_vehicule = new List<cmetier.Vehicule>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string imma = reader.GetString(1);

                vehicule = new cmetier.Vehicule(id, 0, "", "", imma);
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }
    }
}

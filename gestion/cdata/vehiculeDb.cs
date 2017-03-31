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
               
                vehicule = new cmetier.Vehicule(id, annee, 0, marque, modele, "", "diesel");
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }

        // *NICO* public List<cmetier.Vehicule> getVehicule()
        //{
        //  string req = "select * from vehicules";
        //  MySqlCommand cmd = form_gestion.instance.CreateCommand();
        //cmd.CommandText = req;
        //  MySqlDataReader reader;
        //reader = cmd.ExecuteReader();
        //  cmetier.Vehicule vehicule;
        //  List<cmetier.Vehicule> list_vehicule = new List<cmetier.Vehicule>();
        //while (reader.Read())
        //{
        //      int id = reader.GetInt32(0);
        //      int annee = reader.GetInt32(1);
        //      int nbKmCompteur = reader.GetInt32(2);
        //      string marque = reader.GetString(3);
        //      string modele = reader.GetString(4);
        //      string motorisation = reader.GetString(5);
        //
        //      vehicule = new cmetier.Vehicule(id, annee, nbKmCompteur, marque, modele, "",motorisation);
        //        list_vehicule.Add(vehicule);
        //      }
        //    reader.Close();
        //      return list_vehicule;
        //    }
        // }

        public string getVehiculeId(string marque, string modele, string annee)
        {
            string id = "0";

            string req = "select id from marque_modele where annee=@annee and marque=@marque and modele=@modele";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;

            cmd.Parameters.Add(new MySqlParameter("annee", annee));
            cmd.Parameters.Add(new MySqlParameter("marque", marque));
            cmd.Parameters.Add(new MySqlParameter("modele", modele));

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = reader.GetString(0);
            }
            reader.Close();

            return id;
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

                vehicule = new cmetier.Vehicule(id, annee, 0, marque, modele, "", "diesel");
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

                vehicule = new cmetier.Vehicule(0, 0, 0, marque, "", "", "diesel");
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

                vehicule = new cmetier.Vehicule(0, 0, 0, "", modele, "", "diesel");
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

                vehicule = new cmetier.Vehicule(0, annee, 0, "", "", "", "diesel");
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

                vehicule = new cmetier.Vehicule(id, 0, 0, "", "", imma, "diesel");
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }

        public void setAffectVehiculeSalarieService(string id_salarie, string id_vehicule)
        {
            string req = "INSERT INTO vehicules VALUES()";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
        }
        public void setVehicule(string id_vehicule, string imma, string nbkmcompteur, string motorisation, DateTime date_achat)
        {
            string req = "INSERT INTO vehicules(id_vehicule, immatriculation, dateAchat, nbKmCompteur, motorisation) VALUES(@id_vehicule, @imma, @date_achat, @nbkmcompteur, @motorisation)";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;

            cmd.Parameters.Add(new MySqlParameter("id_vehicule", id_vehicule));
            cmd.Parameters.Add(new MySqlParameter("imma", imma));

            cmd.Parameters.Add("@date_achat", MySqlDbType.DateTime).Value=date_achat;

            cmd.Parameters.Add(new MySqlParameter("nbkmcompteur", nbkmcompteur));
            cmd.Parameters.Add(new MySqlParameter("motorisation", motorisation));

            cmd.ExecuteNonQuery();
        }
    }
}
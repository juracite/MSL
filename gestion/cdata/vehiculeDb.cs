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
               
                vehicule = new cmetier.Vehicule(id, annee, 0, 0, marque, modele, "", "diesel");
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

        public cmetier.Vehicule getVehiculeById(int id)
        {
            string req = "select * from marque_modele where id='"+ id +"'";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Vehicule vehicule;
            int id_vehicule = 0;
            int annee = 0;
            string marque = "";
            string modele = "";

            while (reader.Read())
            {
                id_vehicule = reader.GetInt32(0);
                annee = reader.GetInt32(1);
                marque = reader.GetString(2);
                modele = reader.GetString(3);             
            }
            reader.Close();

            vehicule = new cmetier.Vehicule(id, annee, 0, 0, marque, modele, "", "diesel");
            return vehicule;
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

                vehicule = new cmetier.Vehicule(0, 0, 0, 0, marque, "", "", "diesel");
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

                vehicule = new cmetier.Vehicule(0, 0, 0, 0, "", modele, "", "diesel");
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

                vehicule = new cmetier.Vehicule(0, annee, 0, 0, "", "", "", "diesel");
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
                int nbKmEnt = reader.GetInt32(4);
                int nbKmDernierEnt = reader.GetInt32(8);

                vehicule = new cmetier.Vehicule(id, 0, nbKmEnt, nbKmDernierEnt, "", "", imma, "diesel");
                list_vehicule.Add(vehicule);
            }
            reader.Close();
            return list_vehicule;
        }

        public void setAffectVehiculeSalarieService(string type_service, string id_vehicule, bool affect_res)
        {
            string req;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();

            if (affect_res)
            {
                personnelDb responsableDb = new personnelDb();
                cmetier.Personnel responsable;

                responsable = responsableDb.getResponsableTypeService(type_service);

                int id_salarie = responsable.Id_salarie;

                req = "UPDATE vehicules SET type_service = @type_service, id_salarie = @id_salarie WHERE id_vehicule = @id_vehicule";

                
                cmd.CommandText = req;

                cmd.Parameters.Add(new MySqlParameter("id_vehicule", id_vehicule));
                cmd.Parameters.Add(new MySqlParameter("type_service", type_service));
                cmd.Parameters.Add(new MySqlParameter("id_salarie", id_salarie));
            }
            else
            {
                req = "UPDATE vehicules SET type_service = @type_service WHERE id_vehicule = @id_vehicule";

                cmd.CommandText = req;

                cmd.Parameters.Add(new MySqlParameter("id_vehicule", id_vehicule));
                cmd.Parameters.Add(new MySqlParameter("type_service", type_service));
            }

            
            cmd.ExecuteNonQuery();
        }
        public string getVehiculeTypeService(string id_vehicule)
        {
            string req = "SELECT type_service FROM vehicules WHERE id_vehicule = @id_vehicule";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();

            string type_service = "";

            cmd.CommandText = req;

            cmd.Parameters.Add(new MySqlParameter("id_vehicule", id_vehicule));

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                type_service = reader.GetString(0);
            }
            reader.Close();

            return type_service;
        }
        public string getVehiculeSalarie(string id_vehicule)
        {
            string req = "SELECT id_salarie FROM vehicules WHERE id_vehicule = @id_vehicule";
            string req1 = "SELECT nom, prenom FROM salarie WHERE id_salarie = @id_salarie";

            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            MySqlDataReader reader;

            string id_salarie = "";
            string nom_prenom = "";

            // ------------
            cmd.CommandText = req;

            cmd.Parameters.Add(new MySqlParameter("id_vehicule", id_vehicule));

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id_salarie = reader.GetString(0);
            }
            reader.Close();

            // ------------

            cmd.CommandText = req1;

            cmd.Parameters.Add(new MySqlParameter("id_salarie", id_salarie));

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nom = reader.GetString(0);
                string prenom = reader.GetString(1);

                nom_prenom = prenom[0].ToString() + "." + nom;
            }
            reader.Close();

            return nom_prenom;
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
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cdata
{
    class personnelDb
    {
        public List<cmetier.Personnel> sendReqInfo()
        {
            string req = "select * from salarie";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Personnel personnel;
            List<cmetier.Personnel> list_personnel = new List<cmetier.Personnel>();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nom = reader.GetString(1);
                string prenom = reader.GetString(2);
                int mobile = reader.GetInt32(3);
                string type_service = reader.GetString(4);
                string mail = reader.GetString(5);
                int responsable = reader.GetInt32(6);

                personnel = new cmetier.Personnel(id, nom, prenom, mobile, type_service, mail, responsable, 0, "");
                list_personnel.Add(personnel);
            }
            reader.Close();
            return list_personnel;
        }
        public MySqlDataReader getInfoSalarieService(string type_service)
        {
            string req = "select * from salarie where type_service='" + type_service + "'";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            return reader;
        }
        public void ajouterSalarie(string nom, string prenom, string mobile, string type_service, string mail, int id_vehicule, string login, string password)
        {
            string id_con = login + password;
            string req = "INSERT INTO salarie(nom, prenom, mobile, type_service, mail, id_vehicule, login, password, id_con) VALUES('" + nom + "','" + prenom + "','" + mobile + "','" + type_service + "','" + mail + "', '" + id_vehicule +"','" + login + "', md5('" + password + "'), md5('" + id_con + "'))";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
        }
        public List<cmetier.Personnel> getSalarieTypeService(string type_service)
        {
            List<cmetier.Personnel> perso = new List<cmetier.Personnel>();

            MySqlDataReader reader_nom;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            string req = "SELECT DISTINCT id_salarie, nom, prenom FROM salarie WHERE type_service='" + type_service + "'";
            cmd.CommandText = req;
            reader_nom = cmd.ExecuteReader();
            while (reader_nom.Read())
            {
                cmetier.Personnel infoperso = new cmetier.Personnel(reader_nom.GetInt32(0), reader_nom.GetString(1), reader_nom.GetString(2), 0, "", "", 0, 0, "");
                perso.Add(infoperso);
            }
            reader_nom.Close();
            return perso;
        }
        public cmetier.Personnel getResponsableTypeService(string type_service)
        {
            cmetier.Personnel perso;
            string nom = "";
            string prenom = "";
            int id_salarie = 0;

            MySqlDataReader reader_nom;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            string req = "SELECT id_salarie, prenom, nom FROM salarie WHERE type_service='" + type_service + "' AND responsable=1";
            cmd.CommandText = req;
            reader_nom = cmd.ExecuteReader();
            while (reader_nom.Read())
            {
                nom = reader_nom.GetString(2);
                prenom = reader_nom.GetString(1);
                id_salarie = reader_nom.GetInt16(0);
            }
            reader_nom.Close();
            perso = new cmetier.Personnel(id_salarie, nom, prenom, 0, "", "", 0, 0, "");
            return perso;
            
        }
        public bool updateResponsableTypeService(cmetier.Personnel responsable, string new_responsable)
        {
            string req;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            req = "UPDATE salarie SET responsable='0' WHERE id_salarie='" + responsable.Id_salarie + "'";
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
            req = "UPDATE salarie SET responsable='1' WHERE id_salarie='" + new_responsable + "'";
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();

            return true;
        }
        public bool updateResponsableTypeService(string new_responsable)
        {
            string req;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            req = "UPDATE salarie SET responsable='1' WHERE id_salarie='" + new_responsable + "'";
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();

            return true;
        }
        public bool deleteSalarie(string id)
        {
            string req = "delete from salarie where id_salarie=" + id + "";
            MySqlCommand cmdSql = gestion.form_gestion.instance.CreateCommand();
            cmdSql.CommandText = req;
            cmdSql.ExecuteNonQuery();
            return true;
        }
        public bool updateSalarie(string id, string nom, string prenom, string mail, string service)
        {
            string req = "UPDATE salarie SET nom = @nom, prenom = @prenom, mail = @mail, type_service = @service WHERE id_salarie = @id";
            MySqlCommand cmdSql = gestion.form_gestion.instance.CreateCommand();
            cmdSql.CommandText = req;

            cmdSql.Parameters.AddWithValue("@nom", nom);
            cmdSql.Parameters.AddWithValue("@prenom", prenom);
            cmdSql.Parameters.AddWithValue("@mail", mail);
            cmdSql.Parameters.AddWithValue("@service", service);
            cmdSql.Parameters.AddWithValue("@id", id);

            cmdSql.ExecuteNonQuery();
            
            return true;
        }
        public string getSalariesVehiculesImma()
        {
            string imma = "";

            MySqlDataReader reader_vehicule;
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            string req = "SELECT immatriculation FROM salarie, vehicules WHERE salarie.id_vehicule = vehicules.id_vehicules";
            cmd.CommandText = req;
            reader_vehicule = cmd.ExecuteReader();
            while (reader_vehicule.Read())
            {
                imma = reader_vehicule.GetString(0);
            }
            reader_vehicule.Close();

            return imma;
        }
    }
}
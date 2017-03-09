using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cdata
{
    class serviceDb
    {
        public List<cmetier.Service> sendReqInfo()
        {
            string req = "select * from service";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            cmetier.Service service;
            List<cmetier.Service> list_service = new List<cmetier.Service>();
            while (reader.Read())
            {
                String type_service = reader.GetString(0);
                String libelle_service = reader.GetString(1);

                service = new cmetier.Service(type_service, libelle_service);
                list_service.Add(service);
            }
            reader.Close();
            return list_service;
        }
        public void setService(string type_service, string libelle_service)
        {
            string req_add = "INSERT INTO service(type_service, libelle_service) VALUES('" + type_service + "','" + libelle_service + "');";
            MySqlCommand cmd_add = form_gestion.instance.CreateCommand();
            cmd_add.CommandText = req_add;
            cmd_add.ExecuteNonQuery();
        }
        public MySqlDataReader getServiceLibelle(string type_service)
        {
            string req_get = "SELECT libelle_service FROM service WHERE type_service='" + type_service + "'";
            MySqlCommand cmd = form_gestion.instance.CreateCommand();
            cmd.CommandText = req_get;
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            return reader;
        }
        public void updateService(string type_service, string libelle_service)
        {
            string req_update = "UPDATE service SET libelle_service='" + libelle_service + "' WHERE type_service='" + type_service + "'";
            MySqlCommand cmd_update = form_gestion.instance.CreateCommand();
            cmd_update.CommandText = req_update;
            cmd_update.ExecuteNonQuery();
        }
    }
}

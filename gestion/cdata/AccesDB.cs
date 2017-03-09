using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gestion.cdata
{
    class AccesDB
    {
        public class DB
        {
            private static DB instanceMysql;
            private MySqlConnection connect;
            // Constructeur
            private DB()
            {
            }

            public static DB getInstance()
            {
                if (instanceMysql == null)
                {
                    instanceMysql = new DB();
                }
                return instanceMysql;
            }
            public MySqlConnection getConnect(string conStr)
            {
                try{
                    connect = new MySqlConnection(conStr);
                    connect.Open();
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
                return connect;
            }
        }
    }
}

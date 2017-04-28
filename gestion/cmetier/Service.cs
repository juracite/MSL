using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace gestion.cmetier
{
    class Service
    {
        string type_service, libelle_service;
        public Service(string type_service, string libelle_service)
        {
            Type_service = type_service;
            Libelle_service = libelle_service;
        }

        public string Libelle_service
        {
            get
            {
                return libelle_service;
            }

            set
            {
                libelle_service = value;
            }
        }

        public string Type_service
        {
            get
            {
                return type_service;
            }

            set
            {
                type_service = value;
            }
        }
    }
}
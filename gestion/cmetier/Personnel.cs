using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace gestion.cmetier
{
    class Personnel
    {
        int id_salarie, id_vehicule;
        string nom, prenom, type_service, mail, immatriculation;
        int responsable;
        public Personnel(int id, string nom, string prenom, int mobile, string type_service, string mail, int responsable, int id_vehicule, string immatriculation)
        {
            this.Id_salarie = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Type_service = type_service;
            this.Mail = mail;
            this.Responsable = responsable;
            this.Id_vehicule = id_vehicule;
            this.immatriculation = immatriculation;
        }

        public int Id_salarie 
        {
            get
            {
                return id_salarie;
            }

            set
            {
                id_salarie = value;
            }
        }

        public int Id_vehicule
        {
            get
            {
                return id_vehicule;
            }

            set
            {
                id_vehicule = value;
            }
        }

        public string Immatriculation
        {
            get
            {
                return immatriculation;
            }

            set
            {
                immatriculation = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public int Responsable
        {
            get
            {
                return responsable;
            }

            set
            {
                responsable = value;
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

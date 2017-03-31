using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cmetier
{
    class Vehicule
    {
        int id, annee, nbKmCompteur;
        string marque, modele, imma, motorisation;
        DateTime date_achat;

        public Vehicule(int id)
        {
            Id = id;
        }
        public Vehicule(int id, int annee, int nbKmCompteur, string marque, string modele, string imma, string motorisation, DateTime date_achat)
        {
            Id = id;
            Annee = annee;
            NbKmCompteur = nbKmCompteur;
            Marque = marque;
            Modele = modele;
            Imma = imma;
            Motorisation = motorisation;
            Date_achat = date_achat;
        }
        public Vehicule(int id, int annee, int nbKmCompteur, string marque, string modele, string imma, string motorisation)
        {
            Id = id;
            Annee = annee;
            NbKmCompteur = nbKmCompteur;
            Marque = marque;
            Modele = modele;
            Imma = imma;
            Motorisation = motorisation;
        }

        public int Annee
        {
            get
            {
                return annee;
            }

            set
            {
                annee = value;
            }
        }
        public int NbKmCompteur
        {
            get
            {
                return nbKmCompteur;
            }

            set
            {
                nbKmCompteur = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Imma { get; private set; }

        public string Marque
        {
            get
            {
                return marque;
            }

            set
            {
                marque = value;
            }
        }

        public string Modele
        {
            get
            {
                return modele;
            }

            set
            {
                modele = value;
            }
        }
        public string Motorisation
        {
            get
            {
                return motorisation;
            }

            set
            {
                motorisation = value;
            }
        }

        public DateTime Date_achat
        {
            get
            {
                return date_achat;
            }

            set
            {
                date_achat = value;
            }
        }
    }
}

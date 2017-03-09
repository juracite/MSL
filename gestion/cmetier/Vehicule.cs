using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cmetier
{
    class Vehicule
    {
        int id, annee;
        string marque, modele, imma;
        public Vehicule(int id, int annee, string marque, string modele, string imma)
        {
            Id = id;
            Annee = annee;
            Marque = marque;
            Modele = modele;
            Imma = imma;
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

    }
}

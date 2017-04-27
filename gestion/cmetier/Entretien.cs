using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cmetier
{
    class Entretien
    {
        private int idEntretien;
        private string dateEntretien;
        private int nbKmCompteur;
        private string commentaire;
        private string idVehicule;
        private int idEntretienType;

        public Entretien(int idEntretien, string dateEntretien, int nbKmCompteur, string commentaire, string idVehicule, int idEntretienType)
        {
            this.idEntretien = idEntretien;
            this.dateEntretien = dateEntretien;
            this.nbKmCompteur = nbKmCompteur;
            this.commentaire = commentaire;
            this.idVehicule = idVehicule;
            this.idEntretienType = idEntretienType;
        }

        public int IdEntretien
        {
            get
            {
                return idEntretien;
            }

            set
            {
                idEntretien = value;
            }
        }

        public string DateEntretien
        {
            get
            {
                return dateEntretien;
            }

            set
            {
                dateEntretien = value;
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

        public string Commentaire
        {
            get
            {
                return commentaire;
            }

            set
            {
                commentaire = value;
            }
        }

        public string IdVehicule
        {
            get
            {
                return idVehicule;
            }

            set
            {
                idVehicule = value;
            }
        }

        public int IdEntretienType
        {
            get
            {
                return idEntretienType;
            }

            set
            {
                idEntretienType = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cmetier
{
    class Entretien
    {
        int id, nbKmCpt, nbKmDernierEnt, idEntType, idRdv;
        string commentaire, entLibelle, imma;
        DateTime dateEnt, dateAchat, dateRdv;

      
        public Entretien(int id, int nbKmCpt, int nbKmDernierEnt, int idEntType, int idRdv, string commentaire, string entLibelle, string imma, DateTime dateEnt, DateTime dateAchat, DateTime dateRdv)
        {
            this.id = id;
            this.nbKmCpt = nbKmCpt;
            this.nbKmDernierEnt = nbKmDernierEnt;
            this.idEntType = idEntType;
            this.idRdv = idRdv;
            this.commentaire = commentaire;
            this.entLibelle = entLibelle;
            this.imma = imma;
            this.dateEnt = dateEnt;
            this.dateAchat = dateAchat;
            this.dateRdv = dateRdv;
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

        public int NbKmCpt
        {
            get
            {
                return nbKmCpt;
            }

            set
            {
                nbKmCpt = value;
            }
        }

        public int NbKmDernierEnt
        {
            get
            {
                return nbKmDernierEnt;
            }

            set
            {
                nbKmDernierEnt = value;
            }
        }

        public int IdEntType
        {
            get
            {
                return idEntType;
            }

            set
            {
                idEntType = value;
            }
        }

        public int IdRdv
        {
            get
            {
                return idRdv;
            }

            set
            {
                idRdv = value;
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

        public string EntLibelle
        {
            get
            {
                return entLibelle;
            }

            set
            {
                entLibelle = value;
            }
        }

        public string Imma
        {
            get
            {
                return imma;
            }

            set
            {
                imma = value;
            }
        }

        public DateTime DateEnt
        {
            get
            {
                return dateEnt;
            }

            set
            {
                dateEnt = value;
            }
        }

        public DateTime DateAchat
        {
            get
            {
                return dateAchat;
            }

            set
            {
                dateAchat = value;
            }
        }

        public DateTime DateRdv
        {
            get
            {
                return dateRdv;
            }

            set
            {
                dateRdv = value;
            }
        }

    }
}

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
        string commentaire, entLibelle, imma, dateEnt, dateAchat, dateRdv;

        public Entretien(int id, int nbKmCpt, int nbKmDernierEnt, int idEntType, int idRdv, string commentaire, string entLibelle, string imma, string dateEnt, string dateAchat, string dateRdv)
        {
            this.Id = id;
            this.NbKmCpt = nbKmCpt;
            this.NbKmDernierEnt = nbKmDernierEnt;
            this.IdEntType = idEntType;
            this.IdRdv = idRdv;
            this.Commentaire = commentaire;
            this.EntLibelle = entLibelle;
            this.Imma = imma;
            this.DateEnt = dateEnt;
            this.DateAchat = dateAchat;
            this.DateRdv = dateRdv;
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

        public string DateEnt
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

        public string DateAchat
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

        public string DateRdv
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

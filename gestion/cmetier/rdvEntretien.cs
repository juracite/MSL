using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cmetier
{
    class rdvEntretien
    {
        private int id;
        private string date;
        private string heure;
        private string commentaire;
        private int idVehicule;

        public rdvEntretien(int unId, string uneDate, string uneHeure, string unCommentaire, int unIdVehicule)
        {
            id = unId;
            date = uneDate;
            heure = uneHeure;
            commentaire = unCommentaire;
            idVehicule = unIdVehicule;
        }

        public int getId()
        {
            return id;
        }
        public string getDate()
        {
            return date;
        }
        public string getHeure()
        {
            return heure;
        }
        public string getCommentaire()
        {
            return commentaire;
        }
        public int getIdVehicule()
        {
            return idVehicule;
        }
    }
}

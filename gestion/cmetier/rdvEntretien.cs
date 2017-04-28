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
        private string imma;

        public rdvEntretien(int unId, string uneDate, string uneHeure, string unCommentaire, string uneImma)
        {
            id = unId;
            date = uneDate;
            heure = uneHeure;
            commentaire = unCommentaire;
            imma = uneImma;
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
        public string getImma()
        {
            return imma;
        }
    }
}

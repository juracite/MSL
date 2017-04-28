using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion.cmetier
{
    public class EntretienType
    {

        private int id;
        private string libelle;
        private int nbKm;
        public EntretienType(int unId, string unLibelle, int unNbKm)
        {
            id = unId;
            libelle = unLibelle;
            nbKm = unNbKm;
        }
        public int getId()
        {
            return id;
        }
        public string getLibelle()
        {
            return libelle;
        }
        public int getNbKm()
        {
            return nbKm;
        }

    }
}

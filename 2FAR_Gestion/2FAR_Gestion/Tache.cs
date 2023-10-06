using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class Tache
    {
        public TP tpTache { get; set; }
        public int idTache { get; set; }
        public string descriptionTache { get; set; }
        public bool isCheckpoint { get; set; }
        public int ordreTache { get; set; }
        public double pointTache { get; set; }
        public int etatTache { get; set; }
        public bool isBonus { get; set; }
        public bool isActif { get; set; }



        public Tache(TP tptache, int idtache, string descriptiontache, bool ischeckpoint, int ordretache, int pointtache, int etattache, bool isbonus, bool isactif)
        {
            this.tpTache = tptache;
            this.tpTache.tacheList.Add(this);
            this.idTache = idtache;
            this.descriptionTache = descriptiontache;
            this.isCheckpoint = ischeckpoint;
            this.ordreTache = ordretache;
            this.pointTache = pointtache;
            this.etatTache = etattache;
            this.isBonus = isbonus;
            this.isActif = isactif;
        }
    }
}

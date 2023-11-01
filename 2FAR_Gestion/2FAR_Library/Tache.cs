using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library
{
    public class Tache
    {
        //public TP tpTache { get; set; }
        public int idTache { get; set; }
        public string descriptionTache { get; set; }
        public bool isCheckpoint { get; set; }
        public int ordreTache { get; set; }
        public double pointTache { get; set; }
        public bool isBonus { get; set; }
        public bool isActif { get; set; }

        public int fk_id_tp { get; set; }

        public Tache( int idtache, string descriptiontache, bool ischeckpoint, int ordretache, int pointtache, bool isbonus, bool isactif, int fkidtp)
        {
            this.idTache = idtache;
            this.descriptionTache = descriptiontache;
            this.isCheckpoint = ischeckpoint;
            this.ordreTache = ordretache;
            this.pointTache = pointtache;
            this.isBonus = isbonus;
            this.isActif = isactif;
            this.fk_id_tp = fkidtp;
        }
    }
}

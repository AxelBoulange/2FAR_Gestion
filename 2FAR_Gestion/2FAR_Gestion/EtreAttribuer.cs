using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class EtreAttribuer
    {
        public int fkIdPromo { get; set; }
        public int fkIdTP { get; set; }
        public DateTime dteFin { get; set; }
        public bool isActif { get; set; }
        public EtreAttribuer(int fkidpromo, int fkidtp, DateTime dtefin, bool isactif)
        {
            this.fkIdPromo = fkidpromo;
            this.fkIdTP = fkidtp;
            this.dteFin = dtefin;
            this.isActif = isactif;
        }
    }
}

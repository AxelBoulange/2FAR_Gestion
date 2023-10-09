using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion.classes
{
    public class EtreAttribuer
    {
        public Promo promo { get; set; }
        public TP tp { get; set; }
        public DateTime dteFin { get; set; }
        public bool isActif { get; set; }
        public EtreAttribuer(Promo lapromo, TP letp, DateTime dtefin, bool isactif)
        {
            this.promo = lapromo;
            promo.etreAttribuersList.Add(this);
            this.tp = letp;
            this.dteFin = dtefin;
            this.isActif = isactif;
        }
    }
}

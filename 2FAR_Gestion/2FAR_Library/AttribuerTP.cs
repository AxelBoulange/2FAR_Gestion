using System;

namespace _2FAR_Library
{
    public class AttribuerTP
    {
        public string dte_fin;
        public Boolean is_actif;
        public TP tp;
        public Promo promotion;

        public AttribuerTP(string dteFin, Boolean isActif, TP tp, Promo promotion)
        {
            this.dte_fin = dteFin;
            this.is_actif = isActif;
            this.tp = tp;
            this.promotion = promotion;
        }
    }
}

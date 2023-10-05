using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class Promo
    {
        public int idPromo { get; set; }
        public string nomPromo { get; set; }

        public Promo(int idpromo, string nompromo)
        {
            this.idPromo = idpromo;
            this.nomPromo = nompromo;
        }
    }
}

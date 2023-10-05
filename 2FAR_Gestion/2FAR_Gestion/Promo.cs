using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class Promo
    {
        List<Utilisateur> utilisateurList { get; set; } 
        public int idPromo { get; set; }
        public string nomPromo { get; set; }

        public Promo(List<Utilisateur> userlist, int idpromo, string nompromo)
        {
            this.utilisateurList = userlist;
            this.idPromo = idpromo;
            this.nomPromo = nompromo;
        }
    }
}

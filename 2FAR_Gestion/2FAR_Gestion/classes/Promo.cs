using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion.classes
{
    public class Promo
    {
        public List<Utilisateur> utilisateurList { get; set; }
        public List<EtreAttribuer> etreAttribuersList { get; set; }
        public int idPromo { get; set; }
        public string nomPromo { get; set; }
        public Promo(int idpromo, string nompromo)
        {
            idPromo = idpromo;
            nomPromo = nompromo;
        }
    }
}

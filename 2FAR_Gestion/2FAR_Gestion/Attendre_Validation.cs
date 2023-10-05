using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class Attendre_Validation
    {
        public int fkIdTache { get; set; }
        public int fkIdUtilisateur { get; set; }
        public DateTime dteDemande { get; set; }
        public Attendre_Validation(int fkidtache, int fkidutilisateur, DateTime dtedemande)
        {
            this.fkIdTache = fkidtache;
            this.fkIdUtilisateur = fkidutilisateur;
            this.dteDemande = dtedemande;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class Attendre_Validation
    {
        public Tache tache { get; set; }
        public Utilisateur utilisateur { get; set; }
        public DateTime dteDemande { get; set; }
        public Attendre_Validation(Tache latache, Utilisateur leutilisateur, DateTime dtedemande)
        {
            this.tache = latache;
            this.utilisateur = leutilisateur;
            this.dteDemande = dtedemande;
        }
    }
}

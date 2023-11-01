using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library
{
    public class Utilisateur
    {
        public int promoUtilisateur{ get; set; }
        public int idUtilisateur { get; set; }
        public string nomUtilisateur { get; set; }
        public string prenomUtilisateur { get; set; }
        public string mailUtilisateur { get; set; }
        public string mdpUtilisateur { get; set; }
        public bool isAdmin { get; set; }
        
            


        public Utilisateur( int idutilisateur, string nomutilisateur, string prenomutilisateur, string mailutilisateur, string mdputilisateur, bool isadmin, int promoutilisateur)
        {
            this.promoUtilisateur = promoutilisateur;
            this.idUtilisateur = idutilisateur;
            this.nomUtilisateur = nomutilisateur;
            this.prenomUtilisateur = prenomutilisateur;
            this.mailUtilisateur = mailutilisateur;
            this.mdpUtilisateur = mdputilisateur;
            this.isAdmin = isadmin;
        }

        
    }
}

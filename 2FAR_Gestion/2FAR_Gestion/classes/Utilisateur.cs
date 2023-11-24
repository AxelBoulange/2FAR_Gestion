using System.Collections.Generic;

namespace _2FAR_Gestion.classes
{
    public class Utilisateur
    {
        public Promo promoUtilisateur { get; set; }
        public List<Valider> validerList { get; set; }
        public int idUtilisateur { get; set; }
        public string nomUtilisateur { get; set; }
        public string prenomUtilisateur { get; set; }
        public string mailUtilisateur { get; set; }
        public string mdpUtilisateur { get; set; }
        public bool isAdmin { get; set; }

        public Utilisateur(Promo promoutilisateur, int idutilisateur, string nomutilisateur, string prenomutilisateur, string mailutilisateur, string mdputilisateur, bool isadmin)
        {
            promoUtilisateur = promoutilisateur;
            promoUtilisateur.utilisateurList.Add(this);
            idUtilisateur = idutilisateur;
            nomUtilisateur = nomutilisateur;
            prenomUtilisateur = prenomutilisateur;
            mailUtilisateur = mailutilisateur;
            mdpUtilisateur = mdputilisateur;
            isAdmin = isadmin;
        }
    }
}

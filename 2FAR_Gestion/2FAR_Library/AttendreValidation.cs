using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library
{
    public class AttendreValidation
    {
        public string dte_demande;
        public int fk_id_utilisateur;
        public int fk_id_tache;

        public AttendreValidation(string dteDemande, int idUtilisateur, int idTache) 
        {
            this.dte_demande = dteDemande;
            this.fk_id_utilisateur = idUtilisateur;
            this.fk_id_tache = idTache;
        }
    }
}

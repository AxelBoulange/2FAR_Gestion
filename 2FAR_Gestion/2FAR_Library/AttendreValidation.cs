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
        public Utilisateur utilisateur;
        public Tache tache;

        public AttendreValidation(string _dteDemande, Utilisateur _utilisateur, Tache _tache) 
        {
            this.dte_demande = _dteDemande;
            this.utilisateur = _utilisateur;
            this.tache = _tache;
        }
    }
}

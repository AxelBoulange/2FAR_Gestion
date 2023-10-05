using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class Valider
    {
        public Tache tacheValider {  get; set; }
        public Utilisateur utilisateurValider { get; set; }
        public string reponse { get; set; }
        public bool isJuste { get; set; }
        public Valider(Tache tachevalider, Utilisateur utilisateurvalider, string reponsee, bool isjuste)
        {
            this.tacheValider = tachevalider;
            this.utilisateurValider = utilisateurvalider;
            this.reponse = reponsee;
            this.isJuste = isjuste;
        }
    }
}

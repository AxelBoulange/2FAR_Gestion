using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion.classes
{
    public class Valider
    {
        public Tache tacheValider { get; set; }
        public Utilisateur utilisateurValider { get; set; }
        public string reponse { get; set; }
        public bool isJuste { get; set; }
        public Valider(Tache tachevalider, Utilisateur utilisateurvalider, string reponsee, bool isjuste)
        {
            tacheValider = tachevalider;
            utilisateurValider = utilisateurvalider;
            utilisateurValider.validerList.Add(this);
            reponse = reponsee;
            isJuste = isjuste;
        }
    }
}

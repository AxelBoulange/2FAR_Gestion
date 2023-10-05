using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class Valider
    {
        public int fkIdTache { get; set; }
        public int fkIdUtilisateur { get; set; }
        public string reponse { get; set; }
        public bool isJuste { get; set; }
        public Valider(int fkidtache, int fkidutilisateur, string reponsee, bool isjuste)
        {
            this.fkIdTache = fkidtache;
            this.fkIdUtilisateur = fkidutilisateur;
            this.reponse = reponsee;
            this.isJuste = isjuste;
        }
    }
}

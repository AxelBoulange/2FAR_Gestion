using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion.classes
{
    public class TP
    {
        public List<Tache> tacheList { get; set; }
        public int idTP { get; set; }
        public string nomTP { get; set; }
        public string descriptionTP { get; set; }

        public TP(int idtp, string nomtp, string descriptiontp)
        {
            idTP = idtp;
            nomTP = nomtp;
            descriptionTP = descriptiontp;
        }
    }
}

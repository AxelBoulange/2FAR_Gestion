using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Gestion
{
    public class TP
    {
        public int idTP { get; set; }
        public string nomTP { get; set; }
        public string descriptionTP { get; set; }


        public TP(int idtp, string nomtp, string descriptiontp)
        {
            this.idTP = idtp;
            this.nomTP = nomtp;
            this.descriptionTP = descriptiontp;
        }
    }
}

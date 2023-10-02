using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _2FAR_Library;

namespace _2FAR_Gestion
{
    public class TP
    {
        public bool isCheckpoint {  get; set; }
        public bool isActif {  get; set; }
        public bool isBonus { get; set; }
        public string descriptionTache { get; set; }
        public int ordreTache { get; set; }
        public double pointTache { get; set; }
        public int etatTache { get; set; }


        public TP(bool ischeckpoint, bool isactif, bool isbonus, string descriptiontache,int ordretache,int pointtache, int etattache) 
        { 
            this.isCheckpoint = ischeckpoint;
            this.isActif = isactif;
            this.isBonus = isbonus;
            this.descriptionTache = descriptiontache;
            this.ordreTache = ordretache;
            this.pointTache = pointtache;
            this.etatTache = etattache;
        }
    }
    public partial class ListeTp : Page
    {
        List<TP> tpList = new List<TP>();
        public ListeTp()
        {
            tpList.Add(new TP(false, true, false, "first", 1, 5, 0));
            tpList.Add(new TP(true, true, false, "second", 2, 15, 0));
            tpList.Add(new TP(false, false, true, "third", 3, 5, 0));
            InitializeComponent();
            content.Children.Add(new NavBar());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int idTP {  get; set; }
        public string nomTP { get; set; }
        public string descriptionTP { get; set; }

        List<Tache> listTaches = new List<Tache>();

        public TP(int idtp, string nomtp, string descriptiontp, List<Tache> listtaches)
        {
            this.idTP = idtp;
            this.nomTP = nomtp;
            this.descriptionTP = descriptiontp;
            this.listTaches = listtaches;
        }
    }
    public class Tache
    {
        public int idTache { get; set; }
        public bool isCheckpoint {  get; set; }
        public bool isActif {  get; set; }
        public bool isBonus { get; set; }
        public string descriptionTache { get; set; }
        public int ordreTache { get; set; }
        public double pointTache { get; set; }
        public int etatTache { get; set; }


        public Tache(int idtache,bool ischeckpoint, bool isactif, bool isbonus, string descriptiontache,int ordretache,int pointtache, int etattache) 
        { 
            this.idTache= idtache;
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
        List<Tache> tacheListTp1 = new List<Tache>();
        List<Tache> tacheListTp2 = new List<Tache>();
        List<Tache> tacheListTp3 = new List<Tache>();

        List<TP> TPs = new List<TP>();

        public ListeTp()
        {
            tacheListTp1.Add(new Tache(1, false, true, false, "first TP1", 1, 5, 0));
            tacheListTp1.Add(new Tache(2, true, true, false, "second TP1", 2, 15, 0));
            tacheListTp1.Add(new Tache(3, false, false, true, "third TP1", 3, 5, 0));

            tacheListTp2.Add(new Tache(1, false, true, false, "first TP2", 1, 5, 0));
            tacheListTp2.Add(new Tache(2, true, true, false, "second TP2", 2, 15, 0));
            tacheListTp2.Add(new Tache(3, false, false, true, "third TP2", 3, 5, 0));

            tacheListTp3.Add(new Tache(1, false, true, false, "first TP3", 1, 5, 0));
            tacheListTp3.Add(new Tache(2, true, true, false, "second TP3", 2, 15, 0));
            tacheListTp3.Add(new Tache(3, false, false, true, "third TP3", 3, 5, 0));



            TPs.Add(new TP(1, "TP1", "Description du Tp numero 1", tacheListTp1));
            TPs.Add(new TP(2, "TP2", "Description du Tp numero 2", tacheListTp2));
            TPs.Add(new TP(3, "TP2", "Description du Tp numero 3", tacheListTp3));



            InitializeComponent();
            content.Children.Add(new NavBar(CreateTP, ListTP, VoirEleve, VoirPromos, DemandeValidation));
        }
        private void CreateTP()
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new CreationTP();
            }
        }
        private void ListTP()
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new ListeTp();
            }
        }
        private void VoirEleve()
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new VoirEleve();
            }
        }
        private void VoirPromos()
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new VoirPromos();
            }
        }
        private void DemandeValidation()
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new DemandeValidation();
            }
        }
    }
}

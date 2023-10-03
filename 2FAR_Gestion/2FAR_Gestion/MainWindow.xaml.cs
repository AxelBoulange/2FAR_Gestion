using System;
using System.Windows;
using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


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
    public class Tache
    {
        public int fkIdTP { get; set; }
        public int idTache { get; set; }
        public string descriptionTache { get; set; }
        public bool isCheckpoint { get; set; }
        public int ordreTache { get; set; }
        public double pointTache { get; set; }
        public int etatTache { get; set; }
        public bool isBonus { get; set; }
        public bool isActif { get; set; }
        


        public Tache(int fkidtp,int idtache, string descriptiontache, bool ischeckpoint, int ordretache, int pointtache, int etattache, bool isbonus, bool isactif)
        {
            this.fkIdTP = fkidtp;
            this.idTache = idtache;
            this.descriptionTache = descriptiontache;
            this.isCheckpoint = ischeckpoint;
            this.ordreTache = ordretache;
            this.pointTache = pointtache;
            this.etatTache = etattache;
            this.isBonus = isbonus;
            this.isActif = isactif;
        }
    }
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
    public class Attendre_Validtation
    {
        public int fkIdTache { get; set; }
        public int fkIdUtilisateur { get; set; }
        public DateTime dteDemande { get; set; }
        public Attendre_Validtation(int fkidtache, int fkidutilisateur, DateTime dtedemande)
        {
            this.fkIdTache = fkidtache;
            this.fkIdUtilisateur = fkidutilisateur;
            this.dteDemande = dtedemande;
        }
    }
    public class Utilisateur
    {
        public int fkIdPromo { get; set; }
        public int idUtilisateur { get; set; }
        public string nomUtilisateur { get; set; }
        public string prenomUtilisateur { get; set; }
        public string mailUtilisateur { get; set; }
        public string mdpUtilisateur { get; set; }
        public bool isAdmin { get; set; }

        public Utilisateur(int fkidpromo,int idutilisateur, string nomutilisateur, string prenomutilisateur, string mailutilisateur, string mdputilisateur, bool isadmin)
        {
            this.fkIdPromo = fkidpromo;
            this.idUtilisateur = idutilisateur;
            this.nomUtilisateur= nomutilisateur;
            this.prenomUtilisateur = prenomutilisateur;
            this.mailUtilisateur = mailutilisateur;
            this.mdpUtilisateur = mdputilisateur;
            this.isAdmin = isadmin;
        }
    }

    public class Promo
    {
        public int idPromo { get; set; }
        public string nomPromo { get; set; }

        public Promo(int idpromo, string nompromo)
        {
            this.idPromo = idpromo;
            this.nomPromo = nompromo;
        }
    }
    public class EtreAttribuer
    {
        public int fkIdPromo { get; set; }
        public int fkIdTP { get; set; }
        public DateTime dteFin { get; set; }
        public bool isActif { get; set; }
        public EtreAttribuer(int fkidpromo, int fkidtp, DateTime dtefin, bool isactif)
        {
            this.fkIdPromo = fkidpromo;
            this.fkIdTP = fkidtp;
            this.dteFin = dtefin;
            this.isActif = isactif;
        }
    }
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = new PageAccueil();
        }
        private void MainWindow_Closing()
        {

        }
    }
}
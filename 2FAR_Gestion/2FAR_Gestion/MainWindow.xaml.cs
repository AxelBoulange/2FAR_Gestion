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
using _2FAR_Library;
using _2FAR_Library.Ado;
using System.Data.SqlClient;
using System.ComponentModel;

namespace _2FAR_Gestion
{
    public partial class MainWindow : MetroWindow
    {
        // public static List<AttendreValidation> listeAttenteValidations;
        // public static List<AttribuerTP> listeAttributions;
        // public static List<Valider> listeValidations;
        // public static List<AvancementTache> listeAvancementTaches;
        // public static List<Promo> listePromotions;
        // public static List<Utilisateur> listeUtilisateurs;
        // public static List<Tache> listeTaches;
        // public static List<TP> listeTP;


        public MainWindow()
        {
            // listeTaches = AdoTache.getAdoTache(Connexion.GetConn());
            // listeTP = AdoTP.GetAdoTP(Connexion.GetConn(), listeTaches); // taches
            //
            //
            // listeUtilisateurs = AdoUtilisateur.getAdoUtilisateur(Connexion.GetConn());
            // listePromotions = AdoPromos.getAdoPromos(Connexion.GetConn(), listeUtilisateurs); // utilisateurs
            //
            // listeAttributions = AdoAttribuerTP.getAdoAttribuerTP(Connexion.GetConn(), listeTP, listePromotions); //TP ET PROMO
            //
            // listeAttenteValidations = AdoAttendreValidation.getAdoAttendreValidation(Connexion.GetConn(), listeUtilisateurs, listeTaches); //utilisateurs ET Taches
            // listeValidations = AdoValider.getAdoValider(Connexion.GetConn(), listeUtilisateurs, listeTaches); //Utilisateurs taches
            // listeAvancementTaches = AdoAvancementTache.getAdoAvancementTache(Connexion.GetConn(), listeUtilisateurs, listeTaches); //utilisateurs et taches

            Ados.GetAdos();
            var dumb = Ados.listeAttenteValidations;
            var d1 = Ados.listeAttributions;
            var d2 = Ados.listeValidations;
            var d3 = Ados.listeAvancementTaches;
            var d4 = Ados.listePromotions;
            var d5 = Ados.listeUtilisateurs;
            var d6 = Ados.listeTaches;
            var d7 = Ados.listeTP;
            
            InitializeComponent();
            this.Content = new PageAccueil();

            this.Closing += (object? sender, CancelEventArgs e) =>
            {
                MainWindow_Closing();
            };
              
        }

        private void MainWindow_Closing()
        {
            AdoToDB.suppressionDB();
            AdoToDB.reinsertionDB();
        }
    }
}
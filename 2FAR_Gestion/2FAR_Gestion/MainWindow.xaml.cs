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
using System.Data.SqlClient;

namespace _2FAR_Gestion
{
    public partial class MainWindow : MetroWindow
    {
        

        public MainWindow()
        {
            
            InitializeComponent();
            this.Content = new PageAccueil();
        }
        private void MainWindow_Closing()
        {
            //initialisation de la connexion
            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();
            
            //initialisation des requêtes de suppression
            string sqlDeleteValider = "DELETE FROM valider";
            string sqlDeleteAttribuerTP = "DELETE FROM etre_attribuer";
            string sqlDeleteAvancementTache = "DELETE FROM avancement_tache";
            string sqlDeleteAttendreValidation = "DELETE FROM attendre_validation";

            string sqlDeleteUtilisateur = "DELETE FROM utilisateur";
            string sqlDeletePromo = "DELETE FROM promotion";
            string sqlDeleteTache = "DELETE FROM tache";
            string sqlDeleteTP = "DELETE FROM tp";


            //suppression des tables
            /*SqlCommand cmdValider = new SqlCommand(sqlDeleteValider, conn);
            cmdValider.ExecuteReader();
            SqlCommand cmdAttribuerTP = new SqlCommand(sqlDeleteAttribuerTP, conn);
            cmdAttribuerTP.ExecuteReader();
            SqlCommand cmdAvancementTache = new SqlCommand(sqlDeleteAvancementTache, conn);
            cmdAvancementTache.ExecuteReader();
            SqlCommand cmdAttendreValidation = new SqlCommand(sqlDeleteAttendreValidation, conn);
            cmdAttendreValidation.ExecuteReader();
            SqlCommand cmdUtilisateur = new SqlCommand(sqlDeleteUtilisateur, conn);
            cmdUtilisateur.ExecuteReader();
            SqlCommand cmdPromo = new SqlCommand(sqlDeletePromo, conn);
            cmdPromo.ExecuteReader();
            SqlCommand cmdTache = new SqlCommand(sqlDeleteTache, conn);
            cmdTache.ExecuteReader();
            SqlCommand cmdTP = new SqlCommand(sqlDeleteTP, conn);
            cmdTP.ExecuteReader();
            */
            //inserer les données 
            // Ordre Promo -> Utilisateur -> TP -> Tache -> Attribuer_TP -> Valider -> Attendre_validation -> Avancement_tache
        }
        

        
    }
}
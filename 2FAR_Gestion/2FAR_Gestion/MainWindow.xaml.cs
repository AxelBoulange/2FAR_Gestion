﻿using System;
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
        public static List<AttendreValidation> listeAttenteValidations;
        public static List<AttribuerTP> listeAttributions;
        public static List<Valider> listeValidations;
        public static List<AvancementTache> listeAvancementTaches;
        public static List<Promo> listePromotions;
        public static List<Utilisateur> listeUtilisateurs;
        public static List<Tache> listeTaches;
        public static List<TP> listeTP;
        

        public MainWindow()
        {
            listeAttenteValidations = AdoAttendreValidation.getAdoAttendreValidation();
            listeAttributions = AdoAttribuerTP.getAdoAttribuerTP();
            listeValidations = AdoValider.getAdoValider();
            listeAvancementTaches = AdoAvancementTache.getAdoAvancementTache();
            listePromotions = AdoPromos.getAdoPromos();
            listeUtilisateurs = AdoUtilisateur.getAdoUtilisateur();
            listeTaches = AdoTache.getAdoTache();
            listeTP = AdoTP.GetAdoTP();
            InitializeComponent();
            this.Content = new PageAccueil();

            this.Closing += (object? sender, CancelEventArgs e) =>
            {
                MainWindow_Closing();
            };
              
        }

        private void MainWindow_Closing()
        {

            //initialisation de la connexion
            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();
            /*
            //suppression des tables
            SqlCommand cmdDelete = new SqlCommand();
            conn.Open();
            cmdDelete.Connection = conn;
            cmdDelete.CommandText = "DELETE FROM valider";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM avancement_tache";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM etre_attribuer";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM avancement_tache";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM attendre_validation";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM utilisateur";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM promotion";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM tache";
            cmdDelete.ExecuteNonQuery();
            cmdDelete.CommandText = "DELETE FROM tp";
            cmdDelete.ExecuteNonQuery();
            
            //remettre les autoincrement à 1 
            SqlCommand cmd = new SqlCommand(); 

            cmd.Connection = conn;
            
            cmd.CommandText = "DBCC CHECKIDENT (promotion, RESEED, 0)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DBCC CHECKIDENT (utilisateur, RESEED, 0)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DBCC CHECKIDENT (tp, RESEED, 0)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DBCC CHECKIDENT (tache, RESEED, 0)";
            cmd.ExecuteNonQuery();
            
            //inserer les données 
            // Ordre Promo -> Utilisateur -> TP -> Tache -> Attribuer_TP -> Valider -> Attendre_validation -> Avancement_tache
            
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;

           

            string sqlPromo = "INSERT INTO promotion (nom_promotion) VALUES (@nom_promotion)";
            foreach (Promo p in listePromotions) 
            {
                cmdInsert.CommandText = sqlPromo;
                cmdInsert.Parameters.AddWithValue("@nom_promotion", p.nomPromo);
                cmdInsert.ExecuteNonQuery();
            }
            string sqlUtilisateur = "INSERT INTO utilisateur (nom_utilisateur, prenom_utilisateur, mail_utilisateur, mdp_utilisateur, is_admin, fk_id_promo) VALUES (@nom_utilisateur, @prenom_utilisateur, @mail_utilisateur, @mdp_utilisateur, @is_admin, @fk_id_promo)";
            foreach(Utilisateur u in listeUtilisateurs)
            {
                cmdInsert.CommandText = sqlUtilisateur;
                cmdInsert.Parameters.AddWithValue("@nom_utilisateur", u.nomUtilisateur);
                cmdInsert.Parameters.AddWithValue("@prenom_utilisateur", u.prenomUtilisateur);
                cmdInsert.Parameters.AddWithValue("@mail_utilisateur", u.mailUtilisateur);
                cmdInsert.Parameters.AddWithValue("@mdp_utilisateur", u.mdpUtilisateur);
                cmdInsert.Parameters.AddWithValue("@is_admin", u.isAdmin);
                cmdInsert.Parameters.AddWithValue("@fk_id_promo", u.fk_id_promo);
                cmdInsert.ExecuteNonQuery();
            }
            string sqlTP = "INSERT INTO tp (nom_tp, description_tp) VALUES (@nom_tp, @description_tp)";
            foreach (TP t in listeTP)
            {
                cmdInsert.CommandText= sqlTP;
                cmdInsert.Parameters.AddWithValue("@nom_tp", t.nomTP);
                cmdInsert.Parameters.AddWithValue("@description_tp", t.descriptionTP);
                cmdInsert.ExecuteNonQuery();
            }
            string sqlTache = "INSERT INTO tache (description_tache, ordre_tache, point_etape, is_bonus, is_actif, fk_id_tp, titre_tache, is_checkpoint) VALUES (@description_tache, @ordre_tache, @point_tache, @is_bonus, @is_actif, @fk_id_tp, @titre_tache, @is_checkpoint)";
            foreach (Tache t in listeTaches)
            {
                cmdInsert.CommandText = sqlTache;
                cmdInsert.Parameters.AddWithValue("@description_tache", t.descriptionTache);
                cmdInsert.Parameters.AddWithValue("@ordre_tache", t.ordreTache);
                cmdInsert.Parameters.AddWithValue("@point_etape", t.pointTache);
                cmdInsert.Parameters.AddWithValue("@is_bonus", t.isBonus);
                cmdInsert.Parameters.AddWithValue("@is_actif", t.isActif);
                cmdInsert.Parameters.AddWithValue("@fk_id_tp", t.fk_id_tp);
                cmdInsert.Parameters.AddWithValue("@titre_tache", t.titreTache) ;
                cmdInsert.Parameters.AddWithValue("@is_checkpoint", t.isCheckpoint);
                cmdInsert.ExecuteNonQuery();
            }
            string sqlAttributionTP = "INSERT INTO (dte_fin, is_actif, fk_id_tp, fk_id_promo) VALUES (@dte_fin, @is_actif, @fk_id_tp, @fk_id_promo)";
            foreach(AttribuerTP a in listeAttributions)
            {
                cmdInsert.CommandText= sqlAttributionTP;
                cmdInsert.Parameters.AddWithValue("@dte_fin", a.dte_fin);
                cmdInsert.Parameters.AddWithValue("@is_actif", a.is_actif);
                cmdInsert.Parameters.AddWithValue("@fk_id_tp", a.tp.idTP);
                cmdInsert.Parameters.AddWithValue("@fk_id_promo", a.promotion.idPromo);
                cmdInsert.ExecuteNonQuery();
            }
            string sqlValidationTP = "INSERT INTO (reponse, is_valide, fk_id_utilisateur,fk_id_tache) VALUES (@reponse, @is_valide, @fk_id_utilisateur, @fk_id_tache)";
            foreach(Valider v in listeValidations)
            {
                cmdInsert.CommandText = sqlValidationTP;
                cmdInsert.Parameters.AddWithValue("@reponse", v.reponse);
                cmdInsert.Parameters.AddWithValue("@is_valide", v.isJuste);
                cmdInsert.Parameters.AddWithValue("@fk_id_utilisateur", v.utilisateurValider.idUtilisateur);
                cmdInsert.Parameters.AddWithValue("@fk_id_tache", v.tacheValider.idTache);
                cmdInsert.ExecuteNonQuery();
            }
            string sqlAttenteValidationTP = "INSERT INTO (dte_demande, fk_id_utilisateur, fk_id_tache) VALUES (@dte_demande, @fk_id_utilisateur, @fk_id_tache)";
            foreach(AttendreValidation v in listeAttenteValidations)
            {
                cmdInsert.CommandText = sqlAttenteValidationTP;
                cmdInsert.Parameters.AddWithValue("@dte_demande", v.dte_demande);
                cmdInsert.Parameters.AddWithValue("@fk_id_utilisateur", v.utilisateur.idUtilisateur);
                cmdInsert.Parameters.AddWithValue("@fk_id_tache", v.tache.idTache);
                cmdInsert.ExecuteNonQuery();
            }
            string sqlAvancementTP = "INSERT INTO avancement_tache (fk_id_tache, fk_id_utilisateur, taux_avancement) VALUES (@fk_id_tache, @fk_id_utilisateur, @taux_avancement)";
            foreach(AvancementTache a in listeAvancementTaches)
            {
                cmdInsert.CommandText = sqlAvancementTP;
                cmdInsert.Parameters.AddWithValue("@fk_id_tache", a.tache.idTache);
                cmdInsert.Parameters.AddWithValue("@fk_id_utilisateur", a.utilisateur.idUtilisateur);
                cmdInsert.Parameters.AddWithValue("@taux_avancement", a.taux_avancement);
                cmdInsert.ExecuteNonQuery();
            }
            conn.Close();
            */
        }
    }
}
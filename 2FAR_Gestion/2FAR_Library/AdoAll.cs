using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using _2FAR_Gestion;

namespace _2FAR_Library
{
    public class AdoAll
    {
        private List<Promo> promos;

        private List<Utilisateur> utilisateur;

        private List<TP> listeTP;

        private List<Tache> taches;

        //private List<Valider>;

        public AdoAll()
        {
            SqlDataReader dataReader;

            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();

            //DataTable dtPromo = new DataTable();
            //String sqlPromo = "SELECT * FROM promotion;";
            //SqlCommand queryPromo = new SqlCommand(sqlPromo, conn);
            //SqlDataAdapter dapPromo = new SqlDataAdapter(queryPromo);
            //conn.Open();
            //dapPromo.Fill(dtPromo);
            //conn.Close();
            //this.promos = dtPromo.AsEnumerable().Select(row => new Promo
            //{

            //});

            DataTable dtUtilisateur = new DataTable();
            String sqlUtilisateur = "SELECT * FROM utilisateur;";
            SqlCommand queryUtilisateur = new SqlCommand(sqlUtilisateur, conn);
            SqlDataAdapter dapUtilisateur = new SqlDataAdapter(queryUtilisateur);
            conn.Open();
            dapUtilisateur.Fill(dtUtilisateur);
            conn.Close();
            this.utilisateur = dtUtilisateur.AsEnumerable().Select(row => new Utilisateur
            {
                idUtilisateur = row.Field<int>("id_utilisateur"),
                nomUtilisateur = row.Field<string>("nom_utilisateur"),
                prenomUtilisateur = row.Field<string>("prenom_utilisateur"),
                mailUtilisateur = row.Field<string>("mail_utilisateur"),
                mdpUtilisateur = row.Field<string>("mdp_utilisateur"),
                isAdmin = row.Field<Boolean>("is_admin")
            });


            DataTable dtTP = new DataTable();
            String sqlTP = "SELECT * FROM tp;";
            SqlCommand queryTP = new SqlCommand(sqlTP, conn);
            SqlDataAdapter dapTP = new SqlDataAdapter(queryTP);
            conn.Open();
            dapTP.Fill(dtTP);
            conn.Close();


            DataTable dtTache = new DataTable();
            String sqlTache = "SELECT * FROM tache;";
            SqlCommand queryTache = new SqlCommand(sqlTache, conn);
            SqlDataAdapter dapTache = new SqlDataAdapter(queryTache);
            conn.Open();
            dapTache.Fill(dtTache);
            conn.Close();


        }


    }
}

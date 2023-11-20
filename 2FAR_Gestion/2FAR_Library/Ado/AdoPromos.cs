using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library.Ado
{
    public class AdoPromos : AdoUtilisateur
    {
        public static List<Promo> getAdoPromos() 
        { 
            List<Utilisateur> utilisateur = getAdoUtilisateur();
            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();
            conn.Open();
            string sql = "SELECT * FROM promotion";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Promo> promotions = new List<Promo>();
            while (reader.Read())
            {
                promotions.Add(new Promo(reader.GetInt16(0), reader.GetString(1)));
            }
            foreach (Promo p in promotions) 
            { 
                foreach(Utilisateur u in utilisateur)
                {
                    if(u.promoUtilisateur == p.idPromo)
                    {
                        p.utilisateurList.Add(u);
                    }
                }
            }
            return promotions;
        }
    }
}

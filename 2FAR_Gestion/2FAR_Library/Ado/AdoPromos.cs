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
        public static List<Promo> getAdoPromos() { 
            List<Utilisateur> utilisateur = getAdoUtilisateur();
            SqlConnection conn = new Connexion().GetConn();
            conn.Open();
            string sql = "SELECT * FROM promotion";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Promo> promotions = new List<Promo>();
            while (reader.Read())
            {
                promotions.Add(new Promo(reader.GetInt32(0), reader.GetString(1)));

            }
            foreach (Promo p in promotions) 
            { 
                foreach(Utilisateur u in utilisateur)
                {
                    if(u.fk_id_promo == p.idPromo)
                    {
                        p.utilisateurList.Add(u);
                    }
                }
            }
            return promotions;
        }
    }
}

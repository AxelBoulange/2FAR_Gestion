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
        public static List<Promo> getAdoPromos(SqlConnection connexion, List<Utilisateur> toutLesUtilisateurs) 
        {
            string sql = "SELECT * FROM promotion";
            SqlCommand cmd = new SqlCommand(sql, connexion);
            List<Promo> promotions = new List<Promo>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                promotions.Add(new Promo(reader.GetInt32(0), reader.GetString(1)));
            foreach (Promo p in promotions) 
            { 
                foreach(Utilisateur u in toutLesUtilisateurs)
                {
                    if(u.fk_id_promo == p.idPromo)
                    {
                        p.utilisateurList.Add(u);
                    }
                }
            }
            connexion.Close();
            return promotions;
        }
    }
}

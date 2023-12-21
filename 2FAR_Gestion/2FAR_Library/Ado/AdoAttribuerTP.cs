using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library.Ado
{
     public class AdoAttribuerTP : AdoTP
    {

        public static List<AttribuerTP>  getAdoAttribuerTP(SqlConnection connexion, List<TP> toutLesTps, List<Promo> touteLesPromotions)
        {
            string sql = "SELECT * FROM etre_attribuer";
            SqlCommand cmd = new SqlCommand(sql, (SqlConnection)connexion);
            List<AttribuerTP> attribuerTPList = new List<AttribuerTP>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                foreach (Promo p in touteLesPromotions)
                {
                    foreach (TP t in toutLesTps)
                    {
                        if (reader.GetInt32(2) == t.idTP && reader.GetInt32(3) == p.idPromo)
                        {
                            attribuerTPList.Add(new AttribuerTP(reader.GetDateTime(0), reader.GetBoolean(1),
                                t, p));
                        }
                    }
                }
            }
            connexion.Close();
            return attribuerTPList;
        }
    }
}

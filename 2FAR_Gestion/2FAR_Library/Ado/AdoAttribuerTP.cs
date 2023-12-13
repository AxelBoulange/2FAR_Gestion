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
        public static List<AttribuerTP> getAdoAttribuerTP()
        {
            List<TP> tp = GetAdoTP();
            List<Promo> promos = getAdoPromos();
            SqlConnection conn = new Connexion().GetConn();
            conn.Open();
            string sql = "SELECT * FROM etre_attribuer";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<AttribuerTP> attribuerTPList = new List<AttribuerTP>();
            while(reader.Read()) 
            {
                foreach(Promo p in promos)
                {
                    foreach(TP t in tp)
                    {
                        if(reader.GetInt32(2) == t.idTP && reader.GetInt32(3) == p.idPromo)
                        {
                            attribuerTPList.Add(new AttribuerTP(reader.GetDateTime(0).ToString(), reader.GetBoolean(1), t, p)); 
                        }
                    }
                }
            }
            return attribuerTPList;
        }
    }
}

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
            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();
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
                        if(reader.GetInt16(2) == t.idTP && reader.GetInt16(3) == p.idPromo)
                        {
                            attribuerTPList.Add(new AttribuerTP(reader.GetString(0), reader.GetBoolean(1), t, p)); 
                        }
                    }
                }
            }
            return attribuerTPList;
        }
    }
}

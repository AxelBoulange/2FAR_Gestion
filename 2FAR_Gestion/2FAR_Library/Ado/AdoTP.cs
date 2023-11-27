using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library.Ado
{
    public class AdoTP : AdoTache
    {
        public static List<TP> GetAdoTP()
        {
            List<Tache> taches = getAdoTache();
            SqlConnection conn = new Connexion().GetConn();
            conn.Open();
            string sql = "SELECT * FROM tp;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<TP> tpList = new List<TP>();
            while (reader.Read())
            {
                tpList.Add(new TP(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            foreach (TP tp in tpList)
            {
                foreach (Tache t in taches)
                {
                    if(t.fk_id_tp == tp.idTP)
                    {
                        tp.tacheList.Add(t);
                    }
                }
            }
            return tpList;
        }
    }
}

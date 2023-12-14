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
        public static List<TP> GetAdoTP(SqlConnection connexion, List<Tache> touteLesTaches)
        {
            string sql = "SELECT * FROM tp;";
            SqlCommand cmd = new SqlCommand(sql, connexion);
            List<TP> tpList = new List<TP>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                tpList.Add(new TP(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            foreach (TP tp in tpList)
            {
                foreach (Tache t in touteLesTaches)
                {
                    if(t.fk_id_tp == tp.idTP)
                    {
                        tp.tacheList.Add(t);
                    }
                }
            }
            connexion.Close();
            return tpList;
        }
    }
}

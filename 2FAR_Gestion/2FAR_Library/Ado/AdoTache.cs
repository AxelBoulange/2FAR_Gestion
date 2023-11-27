using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library.Ado
{
    public class AdoTache : AdoPromos
    {
        public static List<Tache> getAdoTache()
        {
            SqlConnection conn = new Connexion().GetConn();
            conn.Open();
            string sql = "SELECT * FROM tache;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Tache> taches = new List<Tache>();
            while (reader.Read())
                //manque is_checkpoint
            {
                //taches.Add(new Tache(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetInt32(6)));

                taches.Add(new Tache(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(8), reader.GetInt32(2), reader.GetInt32(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetInt32(6), reader.GetString(7)));
            }
            return taches;
        }
    }
}

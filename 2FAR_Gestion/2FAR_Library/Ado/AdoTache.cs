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
            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();
            conn.Open();
            string sql = "SELECT * FROM tache;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Tache> taches = new List<Tache>();
            while (reader.Read())
                //manque is_checkpoint
            {
                taches.Add(new Tache(reader.GetInt16(0), reader.GetString(1), reader.GetBoolean(8), reader.GetInt16(2), reader.GetInt16(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetInt16(6), reader.GetString(7)));
            }
            return taches;
        }
    }
}

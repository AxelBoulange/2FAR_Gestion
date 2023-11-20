using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2FAR_Library.Connexion;

namespace _2FAR_Library.Ado
{
    public class AdoUtilisateur
    {
        

        public static List<Utilisateur> getAdoUtilisateur()
        {
            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();
            conn.Open();
            string sql = "SELECT * FROM utilisateur;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            while(reader.Read())
            {
                utilisateurs.Add(new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetInt32(6)));
            }
            return utilisateurs;
        }
    }
}

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
        public static List<Utilisateur> getAdoUtilisateur(SqlConnection connexion)
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            string sql = "SELECT * FROM utilisateur u INNER JOIN promotion p on p.id_promotion = u.fk_id_promo;";
            SqlCommand cmd = new SqlCommand(sql,(SqlConnection)connexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
                utilisateurs.Add(new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetInt32(6), reader.GetString(8)));
            connexion.Close();
            return utilisateurs;
        }
    }
}

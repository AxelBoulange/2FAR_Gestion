using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library.Ado
{
    public class AdoAvancementTache : AdoTache
    {
        public static List<AvancementTache> getAdoAvancementTache(SqlConnection connexion, List<Utilisateur> toutLesUtilisateurs, List<Tache> touteLesTaches)
        {
            string sql = "SELECT * FROM avancement_tache";
            SqlCommand cmd = new SqlCommand(sql, connexion);
            List<AvancementTache> avancementTaches = new List<AvancementTache>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                foreach (Tache t in touteLesTaches)
                {
                    foreach (Utilisateur u in toutLesUtilisateurs)
                    {
                        if (t.idTache == reader.GetInt32(0) && u.idUtilisateur == reader.GetInt32(1))
                        {
                            avancementTaches.Add(new AvancementTache(reader.GetInt32(2), t, u));
                        }
                    }
                }
            }
            connexion.Close();
            return avancementTaches;
        }

    }
}

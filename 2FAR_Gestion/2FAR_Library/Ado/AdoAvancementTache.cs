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
        public static List<AvancementTache> getAdoAvancementTache()
        {
            List<Utilisateur> utilisateurs = getAdoUtilisateur();
            List<Tache> taches = getAdoTache();
            SqlConnection conn = new Connexion().GetConn();
            conn.Open();
            string sql = "SELECT * FROM avancement_tache";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<AvancementTache> avancementTaches = new List<AvancementTache>();
            while (reader.Read())
            {
                foreach(Tache t in taches)
                {
                    foreach(Utilisateur u in utilisateurs)
                    {
                        if(t.idTache == reader.GetInt32(0) && u.idUtilisateur == reader.GetInt32(1))
                        {
                            avancementTaches.Add(new AvancementTache(reader.GetInt32(2), t, u));
                        }
                    }

                }
            }

                return avancementTaches;
        }

    }
}

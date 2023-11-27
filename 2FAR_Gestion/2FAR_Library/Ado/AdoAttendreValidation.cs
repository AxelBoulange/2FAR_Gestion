using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FAR_Library.Ado
{
    public class AdoAttendreValidation : AdoTache
    {
        public static List<AttendreValidation> getAdoAttendreValidation()
        {
            List<Tache> taches = getAdoTache();
            List<Utilisateur> utilisateurs = getAdoUtilisateur();
            SqlConnection conn = new Connexion().GetConn();
            conn.Open();
            string sql = "SELECT * FROM attendre_validation ORDER BY dte_demande DESC;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<AttendreValidation> attendreValidationList = new List<AttendreValidation>();
            while (reader.Read())
            {
                foreach(Utilisateur u in utilisateurs)
                {
                    foreach(Tache t in taches)
                    {
                        if(reader.GetInt32(1) == u.idUtilisateur && reader.GetInt32(2) == t.idTache)
                        {
                            attendreValidationList.Add(new AttendreValidation(reader.GetDateTime(0).ToString(), u, t));
                        }
                    }
                }
            }
            return attendreValidationList;  
        }
    }
}

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
        public static List<AttendreValidation> getAdoAttendreValidation(SqlConnection connexion, List<Utilisateur> toutLesUtilisateurs, List<Tache> touteLesTaches)
        {
            string sql = "SELECT * FROM attendre_validation ORDER BY dte_demande DESC;";
            SqlCommand cmd = new SqlCommand(sql, connexion);
            List<AttendreValidation> attendreValidationList = new List<AttendreValidation>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    foreach(Utilisateur u in toutLesUtilisateurs)
                    {
                        foreach(Tache t in touteLesTaches)
                        {
                            if(reader.GetInt32(1) == u.idUtilisateur && reader.GetInt32(2) == t.idTache)
                            {
                                attendreValidationList.Add(new AttendreValidation(reader.GetDateTime(0).ToString(), u, t));
                            }
                        }
                    }
                }
            }
            return attendreValidationList;  
        }
    }
}

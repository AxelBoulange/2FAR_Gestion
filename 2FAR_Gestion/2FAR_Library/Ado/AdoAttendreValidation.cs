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
            Connexion connexion = new Connexion();
            SqlConnection conn = connexion.GetConn();
            conn.Open();
            string sql = "SELECT * FROM attendre_validation;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<AttendreValidation> attendreValidationList = new List<AttendreValidation>();
            while (reader.Read())
            {
                foreach(Utilisateur u in utilisateurs)
                {
                    foreach(Tache t in taches)
                    {
                        if(reader.GetInt16(1) == u.idUtilisateur && reader.GetInt16(2) == t.idTache)
                        {
                            attendreValidationList.Add(new AttendreValidation(reader.GetString(0), u, t));
                        }
                    }
                }
            }
            return attendreValidationList;  
        }
    }
}

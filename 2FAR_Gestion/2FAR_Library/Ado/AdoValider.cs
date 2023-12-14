using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2FAR_Library.Ado
{
    public class AdoValider : AdoTache 
    {
        public static List<Valider> getAdoValider(SqlConnection connexion, List<Utilisateur> toutLesUtilisateurs, List<Tache> touteLesTaches)
        {
            string sql = "SELECT * FROM valider;";
            SqlCommand cmd = new SqlCommand(sql, connexion);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Valider> validerList = new List<Valider>();    
            while (reader.Read()) 
            { 
                foreach(Utilisateur u in toutLesUtilisateurs)
                {
                    foreach(Tache t in touteLesTaches)
                    {
                        if (reader.GetInt32(2) == u.idUtilisateur && reader.GetInt32(3) == t.idTache)
                        {
                            validerList.Add(new Valider(t, u, reader.GetString(0), reader.GetBoolean(1))); 
                        }
                    }
                }
            }
            connexion.Close();
            return validerList;
        }
    }
}

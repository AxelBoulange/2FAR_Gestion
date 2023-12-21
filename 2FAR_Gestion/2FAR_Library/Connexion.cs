using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _2FAR_Library
{
    public class Connexion
    {
        public static SqlConnection GetConn()
        {
            SqlConnection connection = new SqlConnection("Data Source=Florian\\sqlexpress;Initial Catalog=gestion_tp;Integrated Security=SSPI");
            connection.Open();
            return connection;
        }
    }
}

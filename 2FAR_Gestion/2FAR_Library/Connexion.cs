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
        private SqlConnection Conn;

        public SqlConnection GetConn()
        {
            return Conn;
        }

        public Connexion() {
            this.Conn = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=gestion_tp;Integrated Security=SSPI");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.sql
{
    public class SqlManager
    {
        private static SqlManager instance; //singleton - Data Acess Object
        private SqlConnection connection;

        private SqlManager()
        {
            this.connection = new SqlConnection("Server=.; Database=PruebaBorrar; Trusted_Connection=True;MultipleActiveResultSets=True;");
        }


        public static SqlManager GetInstance()
        {
            if (SqlManager.instance == null)
            {
                SqlManager.instance = new SqlManager();
            }

            return instance;
        }

        public SqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}

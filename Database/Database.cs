using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Database
{
    
    internal class Database
    {
        private static String connectString = @"Data Source=LAPTOP-BQ1B87CK; Integrated Security=true;Database=CarApp";
        private static SqlConnection conn = null;

        public static SqlConnection GetDatabase()
        {
            if(conn == null)
            {
                conn = new SqlConnection(connectString);
            }
            return conn;
        }
    }
}

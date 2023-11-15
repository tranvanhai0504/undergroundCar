using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Utils
{
    internal class SupportFunc
    {
        public static string generalID()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(10)
                .ToList().ForEach(e => builder.Append(e));
            string id = builder.ToString();

            return id;
        }

        private static int getCountInTable(String table)
        {
            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            string sql = String.Format("SELECT MAX(CAST(SUBSTRING(Trim(ID), 2, LEN(Trim(ID))) AS INT)) AS max_id FROM {0}", table);

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            if (reader.Read())
            {
                count += reader.GetInt32(0);
            }
            conn.Close();

            return count;
        }

        public static string generalIDFormat(String head, String table)
        {
            int numMember = getCountInTable(table) + 1;
            String newnumber = numMember.ToString().PadLeft(4, '0');
            return head + newnumber;
        }

        public static string convertPrice(double price)
        {
            int convert = Convert.ToInt32(price);
            string formattedNumber = string.Format("{0:N}", convert);
            return formattedNumber + " vnd";
        }
    }
}

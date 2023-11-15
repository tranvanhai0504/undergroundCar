using CarApp.Database;
using CarApp.Stucture;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarApp.DAO
{
    internal class ServiceDAO
    {
        
        public static List<Service> getAllServices()
        {
            List<Service> services = new List<Service>();
            SqlConnection conn = Database.Database.GetDatabase();

            SqlCommand cmd = new SqlCommand("Select * from Service", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Service service = new Service(reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetDouble(2));
                services.Add(service);
            }

            conn.Close();

            return services;
        }

        public static void addServiceBill(List<Service> services, string billId)
        {
            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();
            using (SqlTransaction oTransaction = conn.BeginTransaction())
            {
                using (SqlCommand oCommand = conn.CreateCommand())
                {
                    oCommand.Transaction = oTransaction;
                    oCommand.CommandType = CommandType.Text;
                    oCommand.CommandText = "INSERT INTO Bill_Service (ID_Order, ID_Service) VALUES (@idBill, @idService)";
                    oCommand.Parameters.Add(new SqlParameter("@idBill", SqlDbType.NChar));
                    oCommand.Parameters.Add(new SqlParameter("@idService", SqlDbType.NChar));
                    try
                    {
                        foreach (Service service in services)
                        {
                            oCommand.Parameters[0].Value = billId;
                            oCommand.Parameters[1].Value = service.ID;
                            oCommand.ExecuteNonQuery();
                        }
                        oTransaction.Commit();
                    }
                    catch (Exception)
                    {
                        oTransaction.Rollback();
                        throw;
                    }
                }
            }
            conn.Close();


        }
    }
}

using CarApp.Stucture;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.DAO
{
    internal class EmployeeDAO
    {
        public static Employee checkAccount(String username,  String password)
        {
            Employee employee = null;

            try
            {
                String dbPassword = null;
                SqlConnection conn = Database.Database.GetDatabase();
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Employee where username = @username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                
                if (reader.Read())
                {
                    employee = new Employee();
                    employee.ID = reader["ID"].ToString().Trim();
                    employee.Name = reader["Name"].ToString().Trim();
                    employee.Role = Convert.ToInt32(reader["Role"]);
                    employee.Username = reader["Username"].ToString().Trim();
                    dbPassword = reader["Password"].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Can't not find your account.", "Noitice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return null;
                }


                if(!ComparePassword(password, dbPassword))
                {
                    MessageBox.Show("Incorrect password!", "Noitice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return null;
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                
            }

            return employee;
        }

        public static bool ComparePassword(string nativePassword, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(nativePassword, hashPassword);
        }

        public static string HashingPassword(string password)
        {
            int salt = 12;
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }
    }
}

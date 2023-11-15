using CarApp.Stucture;
using CarApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarApp.DAO
{
    internal class CustomerDAO
    {
        public static Customer getCustomer(string customerID)
        {
            Customer customer = new Customer() { Id = customerID};

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Customer where ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", customer.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader != null )
            {
                reader.Read();
                customer.Name = reader.GetString(1).Trim();
                customer.Phone = reader.GetString(2).Trim();
                customer.Email  = reader.GetString(3).Trim();
                customer.Address = reader.GetString(4).Trim();
            }
            else
            {
                throw new Exception("Can't get customer infor");
            }

            conn.Close();

            return customer;
        }
        public static List<Customer> getAllCustomer()
        {
            List<Customer> customers = new List<Customer>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer()
                {
                    Id = reader.GetString(0).Trim(),
                    Name = reader.GetString(1).Trim(),
                    Phone = reader.GetString(2).Trim(),
                    Email = reader.GetString(3).Trim(),
                    Address = reader.GetString(4).Trim(),
                };
                customers.Add(customer);
            }

            conn.Close();

            return customers;
        }

        public static string addNewCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("customer required!");
            }

            customer.Id = SupportFunc.generalIDFormat("C", "Customer");
            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand insertCmd = new SqlCommand("INSERT INTO Customer (ID, Name, Phone, Email, Address) VALUES (@id, @name, @phone, @email, @address)", conn);
            insertCmd.Parameters.AddWithValue("@id", customer.Id);
            insertCmd.Parameters.AddWithValue("@name", customer.Name);
            insertCmd.Parameters.AddWithValue("@phone", customer.Phone);
            insertCmd.Parameters.AddWithValue("@email", customer.Email);
            insertCmd.Parameters.AddWithValue("@address", customer.Address);
            insertCmd.ExecuteNonQuery();

            conn.Close();

            return customer.Id;
        }

        public static bool deleteCustomer(String id)
        {
            try
            {
                SqlConnection conn = Database.Database.GetDatabase();
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Customer where ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM Bill where CarID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool updateCustomer(Customer customer)
        {
            try
            {
                SqlConnection conn = Database.Database.GetDatabase();
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Customer SET Name = @name, Email = @email, Phone = @phone, Address = @address where ID = @id", conn);
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@phone", customer.Phone);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@id", customer.Id);

                int row = cmd.ExecuteNonQuery();

                conn.Close();

                return row > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}

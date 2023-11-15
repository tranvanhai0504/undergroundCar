using CarApp.Stucture;
using CarApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarApp.DAO
{
    internal class ScheduleDAO
    {
        public static string addSchedules(List<Schedule> schedules)
        {
            String id = SupportFunc.generalID();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            using (SqlTransaction oTransaction = conn.BeginTransaction())
            {
                using (SqlCommand oCommand = conn.CreateCommand())
                {
                    oCommand.Transaction = oTransaction;
                    oCommand.CommandType = CommandType.Text;
                    oCommand.CommandText = "INSERT INTO Schedule (ID, [From], [To]) VALUES (@id, @from, @to)";
                    oCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.NChar));
                    oCommand.Parameters.Add(new SqlParameter("@from", SqlDbType.NChar));
                    oCommand.Parameters.Add(new SqlParameter("@to", SqlDbType.NChar));
                    try
                    {
                        foreach (Schedule schedule in schedules)
                        {
                            oCommand.Parameters[0].Value = id;
                            oCommand.Parameters[1].Value = schedule.From;
                            oCommand.Parameters[2].Value = schedule.To;
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

            return id;
        }

        public static List<Schedule> getSchedules(string id)
        {
            List<Schedule> list = new List<Schedule>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            //get infor bill
            SqlCommand cmd = new SqlCommand("SELECT * from Schedule where ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Schedule schedule = new Schedule()
                {
                    Id = reader.GetString(0).Trim(),
                    From = reader.GetString(1).Trim(),
                    To = reader.GetString(2).Trim(),
                };
                list.Add(schedule);
            }

            conn.Close();

            return list;
        }
    }
}

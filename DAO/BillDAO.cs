using CarApp.Stucture;
using CarApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.DAO
{
    internal class BillDAO
    {
        public static bool addNewBill(Bill bill)
        {
            if (bill == null)
            {
                throw new ArgumentNullException("customer required!");
            }
 
            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into Bill(ID, TimeStart, CarID, ScheduleID, CustomerID, Period, Status, EmployeeID, Total_price) values(@id, @timeStart, @carId, @scheduleId, @customerId, @period, @status, @employeeId, @total)", conn);

            cmd.Parameters.AddWithValue("@id", bill.Id);
            cmd.Parameters.AddWithValue("@timeStart", bill.TimeStart.ToString("yyyy-MM-dd H:mm:ss"));
            cmd.Parameters.AddWithValue("@carId", bill.CarID);
            cmd.Parameters.AddWithValue("@scheduleId", bill.ScheduleID);
            cmd.Parameters.AddWithValue("@customerId", bill.CustomerID);
            cmd.Parameters.AddWithValue("@period", bill.Period);
            cmd.Parameters.AddWithValue("@status", bill.Status);
            cmd.Parameters.AddWithValue("@employeeId", bill.EmployeeID);
            cmd.Parameters.AddWithValue("@total", bill.Total_price);

            int row = cmd.ExecuteNonQuery();
            conn.Close();

            return row > 0;

        }

        public static List<Bill> getBillList()
        {
            List<Bill> list = new List<Bill>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            //get infor bill
            SqlCommand cmd = new SqlCommand("select Bill.*, Car.Name as 'carName', Customer.Name as 'customerName', Employee.Name as 'employeeName'  from Bill, Car, Customer, Employee where Bill.CarID = Car.ID and bill.CustomerID = Customer.ID and bill.EmployeeID = Employee.ID", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bill bill = new Bill()
                {
                    Id = reader.GetString(0).Trim(),
                    TimeStart = reader.GetDateTime(1),
                    CarID = reader.GetString(2).Trim(),
                    ScheduleID = reader.GetString(3).Trim(),
                    CustomerID = reader.GetString(4).Trim(),
                    Period = reader.GetInt32(5),
                    Status = reader.GetString(6).Trim(),
                    EmployeeID = reader.GetString(7).Trim(),
                    Total_price = reader.GetDouble(8),
                    CarName = reader.GetString(9).Trim(),
                    CustomerName = reader.GetString(10).Trim(),
                    EmployeeName  = reader.GetString(11).Trim(),
                };
                list.Add(bill);
            }
            
            conn.Close();

            return list;
        }

        public static List<Service> getServicesOfBill(String idBill)
        {
            List<Service> list = new List<Service>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            //get infor bill
            SqlCommand cmd = new SqlCommand("SELECT Service.* from Service, Bill_Service where Bill_Service.ID_Order = @id and Bill_Service.ID_Service = Service.ID", conn);
            cmd.Parameters.AddWithValue("@id", idBill);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Service service = new Service()
                {
                    ID = reader.GetString(0).Trim(),
                    Name = reader.GetString(1).Trim(),
                    Price = reader.GetDouble(2)
                };
                list.Add(service);
            }

            conn.Close();

            return list;
        }

        public static bool finishBill(string idBill)
        {
            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            //get infor bill
            SqlCommand cmd = new SqlCommand("UPDATE Bill SET Status = 'Done' WHERE ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", idBill);
            int row = cmd.ExecuteNonQuery();

            conn.Close();

            return row > 0;
        }

        public static List<DailyPriceInfo> getDailyPrices(int selectedYear, int selectedMonth)
        {
            List<DailyPriceInfo> dailyPrices = new List<DailyPriceInfo>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            // Thực hiện truy vấn để lấy giá trị Total_price, SỐ LƯỢNG (khác nhau) CustomerID, và SỐ LƯỢNG (khác nhau) CarID của từng ngày trong tháng
            SqlCommand cmd = new SqlCommand("SELECT DATEPART(WEEK, TimeStart) AS WeekNumber, SUM(Total_price) AS TotalPrice, COUNT(DISTINCT CustomerID) AS CustomerCount, COUNT(DISTINCT CarID) AS CarCount FROM Bill WHERE YEAR(TimeStart) = @SelectedYear AND MONTH(TimeStart) = @SelectedMonth GROUP BY DATEPART(WEEK, TimeStart) ORDER BY WeekNumber", conn);

            cmd.Parameters.AddWithValue("@SelectedYear", selectedYear);
            cmd.Parameters.AddWithValue("@SelectedMonth", selectedMonth);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DailyPriceInfo dailyPriceInfo = new DailyPriceInfo();
                dailyPriceInfo.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                dailyPriceInfo.CustomerCount = Convert.ToDouble(reader["CustomerCount"]);
                dailyPriceInfo.CarCount = Convert.ToDouble(reader["CarCount"]);

                dailyPrices.Add(dailyPriceInfo);
            }

            conn.Close();

            return dailyPrices;
        }



    }
}

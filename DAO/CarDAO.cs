using CarApp.Stucture;
using CarApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using static System.Windows.Forms.AxHost;

namespace CarApp.DAO
{
    internal class CarDAO
    {
        public static List<CarType> getAllCarType()
        {
            List<CarType> types = new List<CarType>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from CarType", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CarType type = new CarType
                {
                    Id = reader.GetString(0).Trim(),
                    Name = reader.GetString(1).Trim(),
                    BasePrice = reader.GetDouble(2),
                };
                types.Add(type);
            }

            conn.Close();

            return types;
        }

        public static List<Fuel> getAllFuel()
        {
            List<Fuel> fuels = new List<Fuel>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Fuels", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Fuel f = new Fuel
                {
                    Id = reader.GetString(0).Trim(),
                    Name = reader.GetString(1).Trim(),
                    Price = reader.GetDouble(2),
                };
                fuels.Add(f);
            }

            conn.Close();

            return fuels;
        }

        public static List<Car> getAllCar()
        {
            List<Car> cars = new List<Car>();

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Car", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Car f = new Car
                {
                    Id = reader.GetString(0)?.Trim(),
                    Name = reader.GetString(1)?.Trim(),
                    CarTypeID = reader.GetString(2)?.Trim(),
                    Brand = reader.GetString(3)?.Trim(),
                    Status = reader.GetString(4)?.Trim(),
                    BrandPrice = reader.GetDouble(5),
                    FuelID = reader.GetString(6).Trim(),
                };
                cars.Add(f);
            }

            conn.Close();

            return cars;

        }

        public static void updateCarState(String id, bool state)
        {
            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Car SET Status = @state where ID = @id", conn);
            if (state)
            {
                cmd.Parameters.AddWithValue("@state", "Avaiable");
                cmd.Parameters.AddWithValue("@id", id);
            }
            else
            {
                cmd.Parameters.AddWithValue("@state", "Occupied");
                cmd.Parameters.AddWithValue("@id", id);
            }

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static bool deleteCar(string id)
        {
            try
            {
                SqlConnection conn = Database.Database.GetDatabase();
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Car where ID = @id", conn);
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

        public static void updateCar(Car car)
        {
            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Car SET Name = @name, Brand = @brand, BrandPrice = @price, CarTypeID = @typeID, FuelID = @fuelId where ID = @id", conn);

            cmd.Parameters.AddWithValue("@name", car.Name);
            cmd.Parameters.AddWithValue("@brand", car.Brand);
            cmd.Parameters.AddWithValue("@price", car.BrandPrice);
            cmd.Parameters.AddWithValue("@typeID", car.CarTypeID);
            cmd.Parameters.AddWithValue("@fuelID", car.FuelID);
            cmd.Parameters.AddWithValue("@id", car.Id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static bool addCar(Car car)
        {
            String id = SupportFunc.generalIDFormat("C", "Car");
            car.Id = id;

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Car VALUES(@id, @name, @typeCar, @brand, @status, @price, @fuelID)", conn);

            cmd.Parameters.AddWithValue("@id", car.Id);
            cmd.Parameters.AddWithValue("@name", car.Name);
            cmd.Parameters.AddWithValue("@brand", car.Brand);
            cmd.Parameters.AddWithValue("@price", car.BrandPrice);
            cmd.Parameters.AddWithValue("@typeCar", car.CarTypeID);
            cmd.Parameters.AddWithValue("@fuelID", car.FuelID);
            cmd.Parameters.AddWithValue("@status", car.Status);

            int count = cmd.ExecuteNonQuery();

            conn.Close();

            return count > 0;
        }

        public static Car getCar(String id)
        {
            Car car = new Car() { Id = id };

            SqlConnection conn = Database.Database.GetDatabase();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Car where ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", car.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                reader.Read();
                car.Name = reader.GetString(1).Trim();
                car.CarTypeID = reader.GetString(2).Trim();
                car.Brand = reader.GetString(3).Trim();
                car.Status = reader.GetString(4).Trim();
                car.BrandPrice = reader.GetDouble(5);
                car.FuelID = reader.GetString(6).Trim();
            }
            else
            {
                throw new Exception("Can't get car infor");
            }

            conn.Close();

            return car;
        }
    }
}

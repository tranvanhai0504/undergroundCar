using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Stucture
{
    internal class Car
    {
        private string id;
        private string name;
        private string carTypeID;
        private string brand;
        private string status;
        private double brandPrice;
        private string fuelID;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string CarTypeID { get => carTypeID; set => carTypeID = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Status { get => status; set => status = value; }
        public double BrandPrice { get => brandPrice; set => brandPrice = value; }
        public string FuelID { get => fuelID; set =>fuelID = value; }

        public Car() { }
    }
}

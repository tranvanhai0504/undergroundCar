using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Stucture
{
    internal class Bill
    {
        private string id;
        private string customerName;
        private string carName;
        private string carID;
        private string customerID;
        private string scheduleID;
        private DateTime timeStart;
        private int period;
        private string status;
        private string employeeID;
        private string employeeName;
        private double total_price;
        public Bill() { }

        public string Id { get => id; set => id = value; }
        public string CarID { get => carID; set => carID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string ScheduleID { get => scheduleID; set => scheduleID = value; }
        public int Period { get => period; set => period = value; }
        public string Status { get => status; set => status = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public double Total_price { get => total_price; set => total_price = value; }
        public DateTime TimeStart { get => timeStart; set => timeStart = value; }
        public string CarName { get => carName; set => carName = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
    }
}

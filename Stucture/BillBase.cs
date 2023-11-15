namespace CarApp.Stucture
{
    public class BillBase
    {
        private string carID;
        private string carName;
        private string customerID;
        private string customerName;
        private string employeeID;
        private string employeeName;
        private string id;
        private int period;
        private string scheduleID;
        private string status;
        private DateTime timeStart;
        private double total_price;
        public string CarID { get => carID; set => carID = value; }
        public string CarName { get => carName; set => carName = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }

        public string Id { get => id; set => id = value; }
        public int Period { get => period; set => period = value; }
        public string ScheduleID { get => scheduleID; set => scheduleID = value; }
        public string Status { get => status; set => status = value; }
        public DateTime TimeStart { get => timeStart; set => timeStart = value; }
        public double Total_price { get => total_price; set => total_price = value; }
    }
}
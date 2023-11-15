using CarApp.DAO;
using CarApp.Stucture;
using CarApp.UserControls;
using CarApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace CarApp.forms
{
    public partial class DetailBillForm : Form
    {
        private Bill billData;
        private Customer customer;
        private Car car;
        private List<Stucture.Service> services;
        private List<locationItem> locationItems = new List<locationItem>();
        private List<CarType> carTypes = CarDAO.getAllCarType();
        private List<Fuel> fuels = CarDAO.getAllFuel();

        public DetailBillForm()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            customer = CustomerDAO.getCustomer(billData.CustomerID);
            car = CarDAO.getCar(billData.CarID);
            services = BillDAO.getServicesOfBill(billData.Id);
            carTypes = CarDAO.getAllCarType();
            fuels = CarDAO.getAllFuel();

            List<Schedule> schedules = ScheduleDAO.getSchedules(billData.ScheduleID);
            foreach (Schedule schedule in schedules)
            {
                locationItem item = new locationItem(schedule.To, schedule.From);
                locationItems.Add(item);
            }

            txt_status.Text += billData.Status.Trim().ToLower() == "process" ? "Đang thuê" : "Hoàn thành";
            txt_date.Text += billData.TimeStart.ToString();
            txt_employee.Text += billData.EmployeeName;
            txt_name.Text += customer.Name;
            txt_email.Text += customer.Email;
            txt_phone.Text += customer.Phone;
            txt_address.Text += customer.Address;
            txt_total.Text += SupportFunc.convertPrice(calTotalBill());

            string carInfor = $"{car.Name} - {carTypes.Find(type => type.Id.Equals(car.CarTypeID)).Name} - {fuels.Find(fuel => fuel.Id.Equals(car.FuelID)).Name} - {billData.Period} ngày";
            string carPrice = SupportFunc.convertPrice(getCarPrice());

            tableLayoutPanel.RowCount++;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.Controls.Add(renderText(carInfor), 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.Controls.Add(renderText(carPrice), 1, tableLayoutPanel.RowCount - 1);

            foreach (Stucture.Service service in services)
            {
                tableLayoutPanel.RowCount++;
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel.Controls.Add(renderText(service.Name), 0, tableLayoutPanel.RowCount - 1);
                tableLayoutPanel.Controls.Add(renderText(SupportFunc.convertPrice(service.Price)), 1, tableLayoutPanel.RowCount - 1);
                MessageBox.Show((tableLayoutPanel.RowCount - 1).ToString());
            }

            foreach (locationItem location in locationItems)
            {
                flowLayoutLocation.Controls.Add(location);
            }

            if(billData.Status.Trim().ToLower() != "process")
            {
                btn_submit.Enabled = false;
                btn_submit.Text = "Đã hoàn thành";
            }
        }

        private double calTotalBill()
        {
            double totalBill = 0;

            totalBill += getCarPrice();

            foreach (Stucture.Service service in services)
            {
                totalBill += service.Price;
            }

            return totalBill;
        }

        private double getCarPrice()
        {
            double totalBill = 0;

            double baseCar = car.BrandPrice;
            double typeCarPrice = carTypes.Find(type => type.Id.Equals(car.CarTypeID)).BasePrice;
            double fuelPrice = fuels.Find(fuel => fuel.Id.Equals(car.FuelID)).Price;

            totalBill += (baseCar + typeCarPrice + fuelPrice) * billData.Period;

            return totalBill;
        }

        private Label renderText(String text)
        {

            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.FromArgb(0, 91, 65);
            label.Size = new Size(132, 23);
            label.Text = text;

            return label;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Khi thực hiện thao tác này bạn không thể hoàn tác, xác nhận thành toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = BillDAO.finishBill(billData.Id);

                if (result)
                {
                    CarDAO.updateCarState(BillData.CarID, true);
                    MessageBox.Show("Đã thanh toán!");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        internal Bill BillData { get => billData; set => billData = value; }
    }
}

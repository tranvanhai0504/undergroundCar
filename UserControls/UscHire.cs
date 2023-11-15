using CarApp.DAO;
using CarApp.forms;
using CarApp.Properties;
using CarApp.Stucture;
using CarApp.Utils;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service = CarApp.Stucture.Service;

namespace CarApp.UserControls
{
    public partial class UscHire : UserControl
    {
        //item choosed data
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscHire));
        private Guna2Panel itemCarTypeChoose = null;
        private String itemFuelChoose = "All";
        private DateTime dateRent = DateTime.Now;
        private int duration = 1;
        private double total = 0;
        private string IdCarChoosed;
        private String typeChoosed = "None";
        private List<Car> currentListCar;

        //data
        private List<Car> cars;
        private List<Service> services;
        private List<CarType> types;
        private List<Fuel> fuels;
        private List<locationItem> locations = new List<locationItem>();

        public UscHire()
        {
            InitializeComponent();
            loadServices();
            loadCarType();
            loadFuel();
            loadCar();
        }

        private async Task loadCar()
        {
            await Task.Run(() =>
            {
                cars = CarDAO.getAllCar().FindAll(car => car.Status.ToLower() == "avaiable");
                currentListCar = cars;
                DataGridView.DataSource = currentListCar;
            });
        }

        private void loadCarBySort()
        {
            List<Car> carSoft = currentListCar;
            if (!itemFuelChoose.Equals("All"))
            {
                carSoft = cars.FindAll(car => car.FuelID == itemFuelChoose);
            }

            if (!typeChoosed.Equals("None"))
            {
                carSoft = carSoft.FindAll(car => car.CarTypeID == typeChoosed);
            }

            currentListCar = carSoft;
            DataGridView.DataSource = carSoft;
        }

        private void loadServices()
        {
            services = ServiceDAO.getAllServices();

            var index = 0;
            foreach (Service s in services)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Name = "checkBox_" + index;
                checkBox.Size = new Size(78, 24);
                checkBox.TabIndex = 0;
                checkBox.Margin = new Padding(3, 3, 30, 3);
                checkBox.Text = s.Name;
                checkBox.UseVisualStyleBackColor = true;
                checkBox.CheckedChanged += CheckedChanged;
                flowLayoutService.Controls.Add(checkBox);
                index++;
            }
        }

        private void loadFuel()
        {
            fuels = CarDAO.getAllFuel();

            foreach (Fuel f in fuels)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Location = new Point(3, 3);
                radioButton.Name = "radioButton_" + f.Id;
                radioButton.Size = new Size(117, 24);
                radioButton.TabIndex = 0;
                radioButton.TabStop = true;
                radioButton.Text = f.Name;
                radioButton.Margin = new Padding(3, 3, 110, 3);
                radioButton.UseVisualStyleBackColor = true;
                radioButton.CheckedChanged += radioButton_all_CheckedChanged;
                flowLayoutFuel.Controls.Add(radioButton);
            }
        }

        private void loadCarType()
        {
            types = CarDAO.getAllCarType();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chooseCarType(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Guna2Panel item = null;
            if (control.Parent.GetType() == typeof(Guna2Panel))
            {
                item = control.Parent as Guna2Panel;
            }
            else
            {
                item = control as Guna2Panel;
            }

            if (itemCarTypeChoose != null)
            {
                itemCarTypeChoose.BorderColor = Color.Silver;
                item.ForeColor = Color.Silver;
            }

            item.BorderColor = Color.FromArgb(0, 91, 65);
            item.ForeColor = Color.FromArgb(0, 91, 65);
            itemCarTypeChoose = item;

            String typeID = item.Name.Split("_")[1];
            typeChoosed = typeID;
            loadCarBySort();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String searchText = txt_search.Text.ToLower();
            List<Car> carsSearch = currentListCar.FindAll(car => car.Name.ToLower().Contains(searchText) || car.Brand.ToLower().Contains(searchText));
            DataGridView.DataSource = carsSearch;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_addLocation_Click(object sender, EventArgs e)
        {
            String flocation = input_flocation.Text;
            String tlocation = input_tlocation.Text;

            if (flocation.Equals(String.Empty) || tlocation.Equals(String.Empty))
            {
                MessageBox.Show("Please fill full values");
                return;
            }

            locationItem location = new locationItem(tlocation, flocation);
            locations.Add(location);
            flowLayoutLocation.Controls.Remove(btn_delete_location);
            flowLayoutLocation.Controls.Add(location);
            flowLayoutLocation.Controls.Add(btn_delete_location);

            input_tlocation.Text = "";
            input_flocation.Text = tlocation;
            input_tlocation.Focus();
        }

        private void btn_delete_location_Click(object sender, EventArgs e)
        {
            if (locations.Count == 0) return;
            flowLayoutLocation.Controls.Remove(locations[locations.Count - 1]);
            locations.RemoveAt(locations.Count - 1);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            bool state = checkBox.Checked;

            int id = Convert.ToInt32(checkBox.Name.Split("_")[1]);
            services[id].State = state;
            loadDetailBill(1);
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                String IDFuelChoosed = radioButton.Name.Split("_")[1];
                itemFuelChoose = IDFuelChoosed;
                loadCarBySort();
            }

        }

        private void loadDetailBill(int caseEvent)
        {
            switch (caseEvent)
            {
                case 0:
                    {
                        if (IdCarChoosed != null)
                        {
                            Car car = cars.Find(car => car.Id == IdCarChoosed);
                            CarType type = types.Find(type => type.Id == car.CarTypeID);
                            Fuel fuel = fuels.Find(fuel => fuel.Id == car.FuelID);
                            String carDetail = $"Tên xe: {car.Name} - {convertPrice(car.BrandPrice)}\nLoại xe: {type.Name} - {convertPrice(type.BasePrice)}\nLoại nhiên liệu: {fuel.Name} - {convertPrice(fuel.Price)}\nSố ngày thuê: {duration} ngày\nTổng: {convertPrice((car.BrandPrice + type.BasePrice + fuel.Price) * duration)}";

                            txt_car_detail.Text = carDetail;
                        }
                        break;
                    }
                case 1:
                    {
                        dataGridViewBill.Rows.Clear();
                        //update services bill
                        foreach (var service in services)
                        {
                            if (service.State)
                            {
                                DataGridViewRow row = (DataGridViewRow)dataGridViewBill.Rows[0].Clone();
                                row.Cells[0].Value = service.Name;
                                row.Cells[1].Value = convertPrice(service.Price);
                                dataGridViewBill.Rows.Add(row);
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        String date = dateRent.ToString();
                        txt_date_rent.Text = date;
                        break;
                    }
            }
            updateTotalBill();
        }

        private string convertPrice(double price)
        {
            int convert = Convert.ToInt32(price);
            string formattedNumber = string.Format("{0:N}", convert);
            return formattedNumber + " vnd";
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Guna2DateTimePicker dateTimeP = (Guna2DateTimePicker)sender;
            DateTime date = dateTimeP.Value.Date;
            dateRent = date;
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            duration = Convert.ToInt32(guna2NumericUpDown1.Value);
            loadDetailBill(0);
            updateTotalBill();
        }

        private void updateTotalBill()
        {
            //reset total
            total = 0;

            //check car price
            if (IdCarChoosed != null)
            {
                Car car = cars.Find(car => car.Id == IdCarChoosed);
                CarType type = types.Find(type => type.Id == car.CarTypeID);
                Fuel fuel = fuels.Find(fuel => fuel.Id == car.FuelID);
                total += (car.BrandPrice + type.BasePrice + fuel.Price) * duration;
            }

            //check service
            foreach (Service s in services)
            {
                if (s.State)
                {
                    total += s.Price;
                }
            }

            txt_total.Text = convertPrice(total);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = DataGridView.SelectedRows[0];
                String idCarSelected = row.Cells[0].Value.ToString();
                IdCarChoosed = idCarSelected;
                loadDetailBill(0);
                updateTotalBill();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            using (var form = new AddCustomerForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                    //add new Schedule
                    List<Schedule> schedules = new List<Schedule>();
                    foreach (locationItem i in locations)
                    {
                        schedules.Add(new Schedule() { Id = "id", From = i.getSchedule()[0], To = i.getSchedule()[1] });
                    }
                    String idSchedule = ScheduleDAO.addSchedules(schedules);

                    //get employeeID
                    String idEmployee = LoginForm.accountLogined.ID;

                    //==get customerID
                    String customerID;
                    //case choose exist customer
                    if (form.CaseAdd == 1)
                    {
                        customerID = form.DataCustomer.Id;
                    }
                    //case new customer
                    else
                    {
                        customerID = CustomerDAO.addNewCustomer(form.DataCustomer);
                    }

                    String id = SupportFunc.generalIDFormat("B", "Bill");
                    //add new bill
                    Bill newBill = new Bill()
                    {
                        Id = id,
                        CarID = IdCarChoosed,
                        CustomerID = customerID,
                        ScheduleID = idSchedule,
                        EmployeeID = idEmployee,
                        Period = duration,
                        TimeStart = dateRent,
                        Total_price = total,
                        Status = "Process"
                    };

                    bool resultAddBill = BillDAO.addNewBill(newBill);

                    if (resultAddBill)
                    {
                        List<Service> servicesChossed = services.FindAll(service => service.State);
                        ServiceDAO.addServiceBill(servicesChossed, id);

                        MessageBox.Show("Thêm đơn thuê xe thành công!", "Thông báo");
                        //update car state
                        CarDAO.updateCarState(IdCarChoosed, false);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm đơn thuê.", "Lỗi");
                    }
                }
            };
        }
    }
}

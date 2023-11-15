using CarApp.DAO;
using CarApp.forms;
using CarApp.Stucture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp.UserControls
{
    public partial class UscCarManager : UserControl
    {
        private List<Car> carsSort;
        private String idFuelChoosed = "All";
        private string idCarTypeChoosed = "All";
        private Car? carSelected = null;

        private List<Car> cars;
        private List<CarType> types;
        private List<Fuel> fuels;
        public UscCarManager()
        {
            InitializeComponent();
            loadCar();
            loadFuel();
            loadCarType();
        }

        private void loadCar()
        {
            cars = CarDAO.getAllCar();
            carsSort = cars;
            DataGridView.DataSource = cars;
        }

        private void reloadCarUI()
        {
            carsSort = cars;
            DataGridView.DataSource = null;
            DataGridView.DataSource = cars;
        }

        private void loadCarBySort()
        {
            carsSort = cars;
            if (!idFuelChoosed.Equals("All"))
            {
                carsSort = cars.FindAll(car => car.FuelID == idFuelChoosed);
            }

            if (!idCarTypeChoosed.Equals("All"))
            {
                carsSort = carsSort.FindAll(car => car.CarTypeID == idCarTypeChoosed);
            }

            DataGridView.DataSource = carsSort;
        }

        private void loadFuel()
        {
            fuels = CarDAO.getAllFuel();

            foreach (Fuel f in fuels)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Location = new Point(3, 3);
                radioButton.Name = "radioButtonFuel_" + f.Id;
                radioButton.Size = new Size(117, 24);
                radioButton.TabIndex = 0;
                radioButton.TabStop = true;
                radioButton.Text = f.Name;
                radioButton.Margin = new Padding(3, 3, 60, 3);
                radioButton.UseVisualStyleBackColor = true;
                radioButton.CheckedChanged += radioButton_Fuel_CheckedChanged;
                flowLayoutFuel.Controls.Add(radioButton);
            }
        }

        private void loadCarType()
        {
            types = CarDAO.getAllCarType();

            foreach (CarType t in types)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Location = new Point(3, 3);
                radioButton.Name = "radioButtonType_" + t.Id;
                radioButton.Size = new Size(117, 24);
                radioButton.TabIndex = 0;
                radioButton.TabStop = true;
                radioButton.Text = t.Name;
                radioButton.Margin = new Padding(3, 3, 110, 3);
                radioButton.UseVisualStyleBackColor = true;
                radioButton.CheckedChanged += radioButton_Type_CheckedChanged;
                flowLayoutPanelFuel.Controls.Add(radioButton);
            }
        }

        private void radioButton_Fuel_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                String IDFuelChoosed = radioButton.Name.Split("_")[1];
                idFuelChoosed = IDFuelChoosed;
                loadCarBySort();
            }
        }

        private void radioButton_Type_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                String IDCarTypeChoosed = radioButton.Name.Split("_")[1];
                idCarTypeChoosed = IDCarTypeChoosed;
                loadCarBySort();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String searchText = txt_search.Text;
            List<Car> carsSearch = carsSort.FindAll(car => car.Name.ToLower().Contains(searchText.ToLower()) || car.Brand.ToLower().Contains(searchText.ToLower()));
            DataGridView.DataSource = carsSearch;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = DataGridView.SelectedRows[0];
                String idCarSelected = row.Cells[0].Value.ToString();
                this.carSelected = cars.Find(car => car.Id.Equals(idCarSelected));

                txt_name_car.Text = carSelected.Name;
                changeStateControl(true);
            }
        }

        private void changeStateControl(bool state)
        {
            btn_change.Enabled = state;
            btn_delete.Enabled = state;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Việc xóa dư liệu này cũng sẽ xóa các dư liệu liên quan khác như hóa đơn. Bạn có chắc chắn muốn xóa dữ liệu xe này? ", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = CarDAO.deleteCar(carSelected.Id);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cars.Remove(carSelected);
                    carSelected = null;
                    txt_name_car.Text = "";
                    changeStateControl(false);
                    reloadCarUI();

                }
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Car carData = new Car()
            {
                Id = "id",
                Name = "",
                BrandPrice = 0,
                CarTypeID = "T08",
                FuelID = "F01",
                Status = "avaiable",
                Brand = ""
            };

            ChangeCarForm form = new ChangeCarForm(1);

            form.Fuels = fuels;
            form.Types = types;
            form.CarData = carData;
            form.renderData();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                bool resultAddCar = CarDAO.addCar(form.CarData);

                if (resultAddCar)
                {
                    MessageBox.Show("Đã thêm xe mới!");
                    cars.Add(carData);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra.");
                }
            }
            reloadCarUI();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            ChangeCarForm form = new ChangeCarForm(1);

            form.Fuels = fuels;
            form.Types = types;
            form.CarData = carSelected;
            form.renderData();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CarDAO.updateCar(form.CarData);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

using CarApp.Stucture;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarApp.forms
{
    public partial class ChangeCarForm : Form
    {
        private List<CarType> types;
        private List<Fuel> fuels;
        private Car carData;

        private string idFuelChoosed;
        public ChangeCarForm(int caseNum)
        {
            InitializeComponent();
        }

        internal List<CarType> Types { get => types; set => types = value; }
        internal List<Fuel> Fuels { get => fuels; set => fuels = value; }
        internal Car CarData { get => carData; set => carData = value; }

        public void renderData()
        {
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
                radioButton.Margin = new Padding(3, 3, 40, 3);
                radioButton.UseVisualStyleBackColor = true;
                flowLayoutPanel_fuel.Controls.Add(radioButton);

                if (f.Id == carData.FuelID)
                {
                    radioButton.Checked = true;
                    idFuelChoosed = f.Id;
                }
            }

            var dataType = new BindingList<KeyValuePair<string, string>>();
            foreach (CarType type in types)
            {
                dataType.Add(new KeyValuePair<string, string>(type.Id, type.Name));
                //guna2ComboBox.Items.Add(type.Name);

            }
            guna2ComboBox.DataSource = dataType;
            guna2ComboBox.ValueMember = "Key";
            guna2ComboBox.DisplayMember = "Value";

            String nameTypeCar = types.Find(type => type.Id == carData.CarTypeID).Name;
            guna2ComboBox.SelectedIndex = guna2ComboBox.FindString(nameTypeCar);

            txt_name.Text = carData.Name;
            txt_brand.Text = carData.Brand;
            txt_price.Value = Convert.ToDecimal(carData.BrandPrice);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                String IDFuelChoosed = radioButton.Name.Split("_")[1];
                idFuelChoosed = IDFuelChoosed;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text;
            String brand = txt_brand.Text;
            String price = txt_price.Text;
            String carType = guna2ComboBox.SelectedValue.ToString();
            Double priceCar = (Double)txt_price.Value;

            if (new List<String>() { name, brand, price }.Contains(String.Empty))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Cảnh báo");
                return;
            }

            carData.Name = name;
            carData.Brand = brand;
            carData.FuelID = idFuelChoosed.ToString();
            carData.BrandPrice = priceCar;
            carData.CarTypeID = carType;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

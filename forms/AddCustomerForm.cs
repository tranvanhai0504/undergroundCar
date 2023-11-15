using CarApp.DAO;
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

namespace CarApp.forms
{
    public partial class AddCustomerForm : Form
    {
        private List<Customer> customers;
        private string idCustomerChoosed;
        public Customer DataCustomer { get; set; }
        public int CaseAdd { get; set; }

        public AddCustomerForm()
        {
            InitializeComponent();
            loadCustomer();
        }

        public void loadCustomer()
        {
            customers = CustomerDAO.getAllCustomer();
            guna2DataGridView1.DataSource = customers;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = guna2DataGridView1.SelectedRows[0];
                String idCarSelected = row.Cells[0].Value.ToString();
                idCustomerChoosed = idCarSelected;

                txt_notice.Text = "Khách hàng đang chọn: " + idCustomerChoosed;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(radioButton_case1.Checked)
            {
                //case add new user
                string name = txt_name.Text;
                string phone = txt_phone.Text;
                string email = txt_mail.Text;
                string address = txt_address.Text;

                if (new List<String>() { name, phone, email, address}.Contains(String.Empty)) { 
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataCustomer = new Customer()
                {
                    Id = "id",
                    Name = name,
                    Phone = phone,
                    Email = email,
                    Address = address
                };
                CaseAdd = 0;
            }
            else
            {
                //case choose exist user
                if (idCustomerChoosed.Equals(String.Empty))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CaseAdd = 1;
                DataCustomer = customers.Find(customer => customer.Id == idCustomerChoosed);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

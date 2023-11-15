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
    public partial class ChangeCustomerForm : Form
    {
        private Customer customerData;
        public ChangeCustomerForm()
        {
            InitializeComponent();
        }

        public void renderUI()
        {
            txt_name.Text = customerData.Name;
            txt_email.Text = customerData.Email;
            txt_phone.Text = customerData.Phone;
            txt_address.Text = customerData.Address;
        }

        private void bnt_submit_Click(object sender, EventArgs e)
        {
            customerData.Name = txt_name.Text;
            customerData.Email = txt_email.Text;
            customerData.Phone = txt_phone.Text;
            customerData.Address = txt_address.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Customer CustomerData { get => customerData; set => customerData = value; }
    }
}

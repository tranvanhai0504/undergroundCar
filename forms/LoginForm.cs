using CarApp.DAO;
using CarApp.Stucture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class LoginForm : Form
    {
        public static Employee accountLogined;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String username = txtb_username.Text.Trim();
            String password = txtb_pwd.Text.Trim();

            Employee account = EmployeeDAO.checkAccount(username, password);
            if (account != null)
            {
                accountLogined = account;
                var mainForm = new MainForm();
                Program.myAppCxt.MainForm = mainForm;
                mainForm.Show();
                this.Close();
            }
        }
    }
}

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
    public partial class UscHome : UserControl
    {
        private Employee accountLogin;
        private List<Bill> bills;

        private List<Bill> billsSort;
        private Bill billSelected;
        public UscHome()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            text_greeting.Text = "Hi! " + accountLogin.Name;
        }

        public void reloadData()
        {
            dataGridView.DataSource = billsSort;
            dataGridView.Columns["CustomerName"].DisplayIndex = 1;
            dataGridView.Columns["CarName"].DisplayIndex = 2;
            dataGridView.Columns["EmployeeName"].DisplayIndex = 3;
            dataGridView.Columns["Period"].DisplayIndex = 4;
            dataGridView.Columns["TimeStart"].DisplayIndex = 5;
            dataGridView.Columns["Status"].DisplayIndex = 6;
            dataGridView.Columns["Total_price"].DisplayIndex = 7;
        }

        private void UscHome_Load(object sender, EventArgs e)
        {
            bills = BillDAO.getBillList();
            billsSort = bills;
            dataGridView.DataSource = billsSort;
            accountLogin = LoginForm.accountLogined;
            text_greeting.Text = "Hi! " + accountLogin.Name;

            dataGridView.Columns["CarID"].Visible = false;
            dataGridView.Columns["ScheduleID"].Visible = false;
            dataGridView.Columns["CustomerID"].Visible = false;
            dataGridView.Columns["ScheduleID"].Visible = false;
            dataGridView.Columns["EmployeeID"].Visible = false;
            dataGridView.Columns["ScheduleID"].Visible = false;

            dataGridView.Columns["CustomerName"].DisplayIndex = 1;
            dataGridView.Columns["CarName"].DisplayIndex = 2;
            dataGridView.Columns["EmployeeName"].DisplayIndex = 3;
            dataGridView.Columns["Period"].DisplayIndex = 4;
            dataGridView.Columns["TimeStart"].DisplayIndex = 5;
            dataGridView.Columns["Status"].DisplayIndex = 6;
            dataGridView.Columns["Total_price"].DisplayIndex = 7;
            dataGridView.Columns["Period"].HeaderText = "Days rent";

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String searchText = txt_search.Text;
            billsSort = bills.FindAll(bill => bill.CustomerName.ToLower().Contains(searchText.ToLower()) || bill.CarName.ToLower().Contains(searchText.ToLower()) || bill.EmployeeName.ToLower().Contains(searchText.ToLower()));
            reloadData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                String idBillSelected = row.Cells[0].Value.ToString();
                this.billSelected = bills.Find(bill => bill.Id.Equals(idBillSelected));

                DetailBillForm form = new DetailBillForm();
                form.BillData = billSelected;
                form.loadData();
                DialogResult result = form.ShowDialog();

                if(DialogResult.OK == result)
                {
                    bills = BillDAO.getBillList();
                    billsSort = bills;
                    dataGridView.DataSource = billsSort;
                }
            }
        }
    }
}

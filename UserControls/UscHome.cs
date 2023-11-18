using CarApp.DAO;
using CarApp.forms;
using CarApp.Stucture;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            int currentYear = DateTime.Now.Year;
            cbb_selectYear.Items.Add("Năm " + currentYear);
            cbb_selectYear.Items.Add("Năm " + (currentYear + 1));
            cbb_selectYear.Items.Add("Năm " + (currentYear + 2));

            // Chọn năm hiện tại làm giá trị mặc định
            cbb_selectYear.SelectedItem = "Năm " + currentYear;

            // Đặt giá trị mặc định cho ccb_selectMonday
            int currentMonth = DateTime.Now.Month;
            for (int i = 1; i <= 12; i++)
            {
                cbb_selectMonth.Items.Add("Tháng " + i);
            }

            // Chọn tháng hiện tại làm giá trị mặc định
            cbb_selectMonth.SelectedItem = "Tháng " + currentMonth;

            LoadChart();
        }

        private void LoadChart()
        {
            // Lấy giá trị đã chọn từ ComboBoxes
            int selectedYear = int.Parse(cbb_selectYear.SelectedItem.ToString().Split(' ')[1]);
            int selectedMonth = int.Parse(cbb_selectMonth.SelectedItem.ToString().Split(' ')[1]);

            // Gọi hàm getDailyPrices để lấy dữ liệu từ cơ sở dữ liệu
            List<DailyPriceInfo> dailyPriceInfos = BillDAO.getDailyPrices(selectedYear, selectedMonth);

            double total = dailyPriceInfos.Sum(info => info.TotalPrice);
            double customerCount = dailyPriceInfos.Sum(info => info.CustomerCount);
            double carCount = dailyPriceInfos.Sum(info => info.CarCount);

            // Cập nhật biểu đồ
            chart.Series.Clear();
            chart.Series.Add("TotalPrice");
            chart.Series.Add("CustomerCount");
            chart.Series.Add("CarCount");

            // Thêm dữ liệu vào biểu đồ và đặt nhãn trục X
            for (int i = 0; i < dailyPriceInfos.Count; i++)
            {
                if (dailyPriceInfos[i].TotalPrice > 0 && dailyPriceInfos[i].CustomerCount > 0 && dailyPriceInfos[i].CarCount > 0)
                {
                    // Thêm DataPoint cho TotalPrice
                    DataPoint totalPriceDataPoint = new DataPoint(i, dailyPriceInfos[i].TotalPrice);
                    totalPriceDataPoint.AxisLabel = "Week " + (i + 1);
                    totalPriceDataPoint.Label = $"{dailyPriceInfos[i].TotalPrice:N0}";
                    chart.Series["TotalPrice"].Points.Add(totalPriceDataPoint);

                    // Thêm DataPoint cho CustomerCount
                    DataPoint customerCountDataPoint = new DataPoint(i, dailyPriceInfos[i].CustomerCount);
                    customerCountDataPoint.AxisLabel = "Week " + (i + 1);
                    customerCountDataPoint.Label = $"{dailyPriceInfos[i].CustomerCount:N0}";
                    chart.Series["CustomerCount"].Points.Add(customerCountDataPoint);

                    // Thêm DataPoint cho CarCount
                    DataPoint carCountDataPoint = new DataPoint(i, dailyPriceInfos[i].CarCount);
                    carCountDataPoint.AxisLabel = "Week " + (i + 1);
                    carCountDataPoint.Label = $"{dailyPriceInfos[i].CarCount:N0}";
                    chart.Series["CarCount"].Points.Add(carCountDataPoint);

                    chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i + 0.5, i - 0.5, "Week " + (i + 1), 0, LabelMarkStyle.None));
                }
            }

            // Cấu hình chiều rộng của cột
            chart.Series["TotalPrice"].ChartType = SeriesChartType.Column; // Set chart type to Column
            chart.Series["TotalPrice"]["PointWidth"] = "0.6"; // Adjust column width (you can experiment with this value)
            chart.Series["CustomerCount"].ChartType = SeriesChartType.Column; // Set chart type to Column
            chart.Series["CustomerCount"]["PointWidth"] = "0.6"; // Adjust column width for CustomerCount
            chart.Series["CarCount"].ChartType = SeriesChartType.Column; // Set chart type to Column
            chart.Series["CarCount"]["PointWidth"] = "0.6"; // Adjust column width for CarCount
            chart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

            HtmlLabel.Text = "Tổng doanh thu trong tháng: " + total.ToString("N0") + " VNĐ" + " - Khách hàng trong tháng: " + customerCount.ToString() + " người" + " - Số lượng xe trong tháng: " + carCount.ToString() + " xe";
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

                if (DialogResult.OK == result)
                {
                    bills = BillDAO.getBillList();
                    billsSort = bills;
                    dataGridView.DataSource = billsSort;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}

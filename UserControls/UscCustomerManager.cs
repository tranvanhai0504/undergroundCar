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
using Microsoft.Office.Interop;
using CarApp.Utils;

namespace CarApp.UserControls
{
    public partial class UscCustomerManager : UserControl
    {
        private List<Customer> customers;

        private Customer selectedCustomer;
        public UscCustomerManager()
        {
            InitializeComponent();
            loadCustomer();

        }

        private void loadCustomer()
        {
            customers = CustomerDAO.getAllCustomer();
            DataGridView.DataSource = customers;
        }

        private void reloadCarUI()
        {
            DataGridView.DataSource = null;
            DataGridView.DataSource = customers;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String searchText = txt_search.Text;
            List<Customer> customersSearch = customers.FindAll(customer => customer.Name.ToLower().Contains(searchText.ToLower()) || customer.Phone.ToLower().Contains(searchText.ToLower()));
            DataGridView.DataSource = customersSearch;
        }

        private void changeStateControl(bool state)
        {
            btn_change.Enabled = state;
            btn_delete.Enabled = state;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = DataGridView.SelectedRows[0];
                String idCustomerSelected = row.Cells[0].Value.ToString();
                this.selectedCustomer = customers.Find(customers => customers.Id.Equals(idCustomerSelected));

                txt_name_customer.Text = selectedCustomer.Name;
                changeStateControl(true);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Việc xóa dư liệu này cũng sẽ xóa các dư liệu liên quan khác như hóa đơn. Bạn có chắc chắn muốn xóa dữ liệu khách hàng này? ", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = CustomerDAO.deleteCustomer(selectedCustomer.Id);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customers.Remove(selectedCustomer);
                    selectedCustomer = null;
                    txt_name_customer.Text = "";
                    changeStateControl(false);
                    reloadCarUI();

                }
                else
                    MessageBox.Show("Có lỗi xãy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            ChangeCustomerForm form = new ChangeCustomerForm();
            form.CustomerData = selectedCustomer;
            form.renderUI();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                bool resultUpdate = CustomerDAO.updateCustomer(form.CustomerData);
                if (resultUpdate)
                {
                    MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
                    reloadCarUI();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu không thành công, có lỗi xảy ra!", "Thông báo");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
                sfd.FileName = "Danh sách khách hàng.xlsx";
                bool fileErr = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileErr = true;
                            MessageBox.Show("Không thể xuất data vào ổ cứng." + ex.Message);
                        }
                    }
                    if (!fileErr)
                    {
                        try
                        {
                            int columnCount = DataGridView.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[DataGridView.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += $"\"{DataGridView.Columns[i].HeaderText}\"" + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < DataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += $"\"{DataGridView.Rows[i - 1].Cells[j].Value}\"" + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
            }

            //try
            //{
            //    SaveFileDialog saveFileDialog = new SaveFileDialog();
            //    saveFileDialog.InitialDirectory = "c:\\";
            //    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
            //    saveFileDialog.FilterIndex = 1;

            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(saveFileDialog.FileName))
            //        {
            //            try
            //            {
            //                File.Delete(saveFileDialog.FileName);
            //            }
            //            catch (IOException ex)
            //            {
            //                MessageBox.Show("Không thể xuất data vào ổ cứng." + ex.Message);
            //            }
            //        }

            //        DataTable dt = Excel.DataGridView_To_Datatable(DataGridView);
            //        dt.exportToExcel(saveFileDialog.FileName);
            //        MessageBox.Show("Data is exported!");
            //    }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

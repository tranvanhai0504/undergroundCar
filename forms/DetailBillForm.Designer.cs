using System.Windows.Forms;

namespace CarApp.forms
{
    partial class DetailBillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            text_greeting = new Label();
            txt_status = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_date = new Label();
            txt_employee = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            txt_name = new Label();
            txt_address = new Label();
            txt_phone = new Label();
            txt_email = new Label();
            flowLayoutLocation = new FlowLayoutPanel();
            btn_submit = new Guna.UI2.WinForms.Guna2Button();
            label13 = new Label();
            panel2 = new Panel();
            txt_total = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // text_greeting
            // 
            text_greeting.AutoSize = true;
            text_greeting.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            text_greeting.ForeColor = Color.FromArgb(0, 91, 65);
            text_greeting.Location = new Point(358, 24);
            text_greeting.Name = "text_greeting";
            text_greeting.Size = new Size(275, 46);
            text_greeting.TabIndex = 5;
            text_greeting.Text = "Chi tiết hóa đơn";
            // 
            // txt_status
            // 
            txt_status.AutoSize = true;
            txt_status.BackColor = Color.Transparent;
            txt_status.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_status.ForeColor = Color.FromArgb(0, 91, 65);
            txt_status.Location = new Point(373, 70);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(113, 28);
            txt_status.TabIndex = 6;
            txt_status.Text = "Trạng thái: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 91, 65);
            label3.Location = new Point(62, 209);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 8;
            label3.Text = "Thông tin xe cho thuê";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 91, 65);
            label4.Location = new Point(62, 13);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 10;
            label4.Text = "Thông tin khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 91, 65);
            label5.Location = new Point(60, 221);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 11;
            label5.Text = "Lộ trình";
            // 
            // txt_date
            // 
            txt_date.AutoSize = true;
            txt_date.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_date.ForeColor = Color.FromArgb(0, 91, 65);
            txt_date.Location = new Point(129, 118);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(132, 23);
            txt_date.TabIndex = 14;
            txt_date.Text = "Ngày cho thuê: ";
            // 
            // txt_employee
            // 
            txt_employee.AutoSize = true;
            txt_employee.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_employee.ForeColor = Color.FromArgb(0, 91, 65);
            txt_employee.Location = new Point(603, 118);
            txt_employee.Name = "txt_employee";
            txt_employee.Size = new Size(170, 23);
            txt_employee.TabIndex = 15;
            txt_employee.Text = "Nhân viên cho thuê: ";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.9172F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0828018F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(70, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(810, 0);
            tableLayoutPanel.TabIndex = 16;
            // 
            // txt_name
            // 
            txt_name.AutoSize = true;
            txt_name.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_name.ForeColor = Color.FromArgb(0, 91, 65);
            txt_name.Location = new Point(92, 58);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(50, 25);
            txt_name.TabIndex = 17;
            txt_name.Text = "Tên: ";
            // 
            // txt_address
            // 
            txt_address.AutoSize = true;
            txt_address.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_address.ForeColor = Color.FromArgb(0, 91, 65);
            txt_address.Location = new Point(91, 160);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(77, 25);
            txt_address.TabIndex = 18;
            txt_address.Text = "Địa chỉ: ";
            // 
            // txt_phone
            // 
            txt_phone.AutoSize = true;
            txt_phone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_phone.ForeColor = Color.FromArgb(0, 91, 65);
            txt_phone.Location = new Point(634, 58);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(125, 25);
            txt_phone.TabIndex = 19;
            txt_phone.Text = "Số điện thoại: ";
            // 
            // txt_email
            // 
            txt_email.AutoSize = true;
            txt_email.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_email.ForeColor = Color.FromArgb(0, 91, 65);
            txt_email.Location = new Point(94, 109);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(66, 25);
            txt_email.TabIndex = 20;
            txt_email.Text = "Email: ";
            // 
            // flowLayoutLocation
            // 
            flowLayoutLocation.AutoSize = true;
            flowLayoutLocation.Location = new Point(92, 262);
            flowLayoutLocation.Margin = new Padding(3, 3, 3, 50);
            flowLayoutLocation.MaximumSize = new Size(786, 100);
            flowLayoutLocation.Name = "flowLayoutLocation";
            flowLayoutLocation.Padding = new Padding(0, 0, 0, 100);
            flowLayoutLocation.Size = new Size(786, 100);
            flowLayoutLocation.TabIndex = 21;
            // 
            // btn_submit
            // 
            btn_submit.BorderRadius = 10;
            btn_submit.Cursor = Cursors.Hand;
            btn_submit.CustomizableEdges = customizableEdges1;
            btn_submit.DisabledState.BorderColor = Color.DarkGray;
            btn_submit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_submit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_submit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_submit.FillColor = Color.FromArgb(0, 91, 65);
            btn_submit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submit.ForeColor = Color.White;
            btn_submit.Location = new Point(718, 547);
            btn_submit.Name = "btn_submit";
            btn_submit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_submit.Size = new Size(160, 45);
            btn_submit.TabIndex = 23;
            btn_submit.Text = "Xác nhận trả xe";
            btn_submit.Click += btn_submit_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 91, 65);
            label13.Location = new Point(729, 452);
            label13.Name = "label13";
            label13.Size = new Size(131, 25);
            label13.TabIndex = 25;
            label13.Text = "Tổng hóa đơn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 91, 65);
            panel2.Location = new Point(243, 412);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 2);
            panel2.TabIndex = 26;
            // 
            // txt_total
            // 
            txt_total.AutoSize = true;
            txt_total.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_total.ForeColor = Color.FromArgb(0, 91, 65);
            txt_total.Location = new Point(737, 491);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(0, 25);
            txt_total.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.Controls.Add(text_greeting);
            panel3.Controls.Add(txt_status);
            panel3.Controls.Add(txt_date);
            panel3.Controls.Add(txt_employee);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 262);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(tableLayoutPanel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 262);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(70, 0, 70, 0);
            panel4.Size = new Size(950, 0);
            panel4.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txt_name);
            panel5.Controls.Add(txt_address);
            panel5.Controls.Add(txt_total);
            panel5.Controls.Add(txt_phone);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(txt_email);
            panel5.Controls.Add(flowLayoutLocation);
            panel5.Controls.Add(btn_submit);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 262);
            panel5.Name = "panel5";
            panel5.Size = new Size(950, 661);
            panel5.TabIndex = 31;
            // 
            // DetailBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(971, 892);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            MaximizeBox = false;
            MaximumSize = new Size(989, 939);
            Name = "DetailBillForm";
            Padding = new Padding(0, 0, 0, 50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin hóa đơn";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text_greeting;
        private Label txt_status;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txt_date;
        private Label txt_employee;
        private TableLayoutPanel tableLayoutPanel;
        private Label txt_name;
        private Label txt_address;
        private Label txt_phone;
        private Label txt_email;
        private FlowLayoutPanel flowLayoutLocation;
        private Guna.UI2.WinForms.Guna2Button btn_submit;
        private Label label13;
        private Panel panel2;
        private Label txt_total;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}
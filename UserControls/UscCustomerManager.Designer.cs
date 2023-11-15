namespace CarApp.UserControls
{
    partial class UscCustomerManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txt_name_customer = new Label();
            btn_delete = new Guna.UI2.WinForms.Guna2Button();
            btn_change = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // txt_name_customer
            // 
            txt_name_customer.AutoSize = true;
            txt_name_customer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_name_customer.ForeColor = Color.FromArgb(0, 91, 65);
            txt_name_customer.Location = new Point(320, 109);
            txt_name_customer.Name = "txt_name_customer";
            txt_name_customer.Size = new Size(0, 25);
            txt_name_customer.TabIndex = 37;
            // 
            // btn_delete
            // 
            btn_delete.BorderRadius = 10;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.CustomizableEdges = customizableEdges1;
            btn_delete.DisabledState.BorderColor = Color.DarkGray;
            btn_delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_delete.Enabled = false;
            btn_delete.FillColor = Color.Firebrick;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(223, 166);
            btn_delete.Name = "btn_delete";
            btn_delete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_delete.Size = new Size(141, 45);
            btn_delete.TabIndex = 35;
            btn_delete.Text = "Xóa khách hàng";
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_change
            // 
            btn_change.BorderRadius = 10;
            btn_change.Cursor = Cursors.Hand;
            btn_change.CustomizableEdges = customizableEdges3;
            btn_change.DisabledState.BorderColor = Color.DarkGray;
            btn_change.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_change.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_change.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_change.Enabled = false;
            btn_change.FillColor = Color.FromArgb(0, 91, 65);
            btn_change.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_change.ForeColor = Color.White;
            btn_change.Location = new Point(76, 166);
            btn_change.Name = "btn_change";
            btn_change.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_change.Size = new Size(141, 45);
            btn_change.TabIndex = 34;
            btn_change.Text = "Sửa thông tin";
            btn_change.Click += btn_change_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 91, 65);
            label4.Location = new Point(76, 104);
            label4.Name = "label4";
            label4.Size = new Size(238, 30);
            label4.TabIndex = 33;
            label4.Text = "Khách hàng đang chọn:";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.Cursor = Cursors.Hand;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(0, 91, 65);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(932, 250);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(141, 45);
            guna2Button2.TabIndex = 28;
            guna2Button2.Text = "Tìm kiếm";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // txt_search
            // 
            txt_search.BorderRadius = 10;
            txt_search.CustomizableEdges = customizableEdges7;
            txt_search.DefaultText = "";
            txt_search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_search.Location = new Point(76, 250);
            txt_search.Name = "txt_search";
            txt_search.PasswordChar = '\0';
            txt_search.PlaceholderText = "Nhập tên hoặc số điện thoại";
            txt_search.SelectedText = "";
            txt_search.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_search.Size = new Size(850, 45);
            txt_search.TabIndex = 27;
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView.ColumnHeadersHeight = 29;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView.Location = new Point(76, 321);
            DataGridView.MultiSelect = false;
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersVisible = false;
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 29;
            DataGridView.Size = new Size(997, 398);
            DataGridView.TabIndex = 26;
            DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView.ThemeStyle.BackColor = Color.White;
            DataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 91, 65);
            DataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView.ThemeStyle.HeaderStyle.Height = 29;
            DataGridView.ThemeStyle.ReadOnly = true;
            DataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView.ThemeStyle.RowsStyle.Height = 29;
            DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView.CellClick += DataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 91, 65);
            label1.Location = new Point(76, 39);
            label1.Name = "label1";
            label1.Size = new Size(284, 32);
            label1.TabIndex = 25;
            label1.Text = "Quản lý khách hàng";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 91, 65);
            guna2Button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(932, 39);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(141, 45);
            guna2Button1.TabIndex = 38;
            guna2Button1.Text = "Xuất dữ liệu";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // UscCustomerManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Button1);
            Controls.Add(txt_name_customer);
            Controls.Add(btn_delete);
            Controls.Add(btn_change);
            Controls.Add(label4);
            Controls.Add(guna2Button2);
            Controls.Add(txt_search);
            Controls.Add(DataGridView);
            Controls.Add(label1);
            Name = "UscCustomerManager";
            Size = new Size(1177, 766);
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_name_customer;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_change;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

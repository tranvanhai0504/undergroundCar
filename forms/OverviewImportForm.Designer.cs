namespace CarApp.forms
{
    partial class OverviewImportForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_change = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 91, 65);
            label1.Location = new Point(455, 26);
            label1.Name = "label1";
            label1.Size = new Size(149, 38);
            label1.TabIndex = 1;
            label1.Text = "Xem trước";
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
            DataGridView.Location = new Point(56, 80);
            DataGridView.MultiSelect = false;
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersVisible = false;
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 29;
            DataGridView.Size = new Size(960, 375);
            DataGridView.TabIndex = 6;
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
            // 
            // btn_change
            // 
            btn_change.BorderRadius = 10;
            btn_change.Cursor = Cursors.Hand;
            btn_change.CustomizableEdges = customizableEdges1;
            btn_change.DisabledState.BorderColor = Color.DarkGray;
            btn_change.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_change.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_change.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_change.Enabled = false;
            btn_change.FillColor = Color.FromArgb(0, 91, 65);
            btn_change.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_change.ForeColor = Color.White;
            btn_change.Location = new Point(875, 480);
            btn_change.Name = "btn_change";
            btn_change.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_change.Size = new Size(141, 45);
            btn_change.TabIndex = 22;
            btn_change.Text = "Thêm";
            btn_change.Click += btn_change_Click;
            // 
            // OverviewImportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1081, 537);
            Controls.Add(btn_change);
            Controls.Add(DataGridView);
            Controls.Add(label1);
            Name = "OverviewImportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OverviewImportForm";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2Button btn_change;
    }
}
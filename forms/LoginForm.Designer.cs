namespace CarApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btn_submit = new Button();
            label3 = new Label();
            label2 = new Label();
            txtb_pwd = new TextBox();
            txtb_username = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 45);
            label1.Name = "label1";
            label1.Size = new Size(273, 41);
            label1.TabIndex = 0;
            label1.Text = "Underground Car";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_submit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtb_pwd);
            panel1.Controls.Add(txtb_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 331);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 91, 65);
            label4.Location = new Point(264, 86);
            label4.Name = "label4";
            label4.Size = new Size(126, 17);
            label4.TabIndex = 8;
            label4.Text = "The car all you need";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(135, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 71);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.FromArgb(0, 91, 65);
            btn_submit.Cursor = Cursors.Hand;
            btn_submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submit.ForeColor = SystemColors.ButtonHighlight;
            btn_submit.Location = new Point(229, 242);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(181, 49);
            btn_submit.TabIndex = 5;
            btn_submit.Text = "Login";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 129, 112);
            label3.Location = new Point(134, 194);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 129, 112);
            label2.Location = new Point(130, 147);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // txtb_pwd
            // 
            txtb_pwd.Location = new Point(216, 191);
            txtb_pwd.Name = "txtb_pwd";
            txtb_pwd.Size = new Size(262, 27);
            txtb_pwd.TabIndex = 2;
            txtb_pwd.UseSystemPasswordChar = true;
            // 
            // txtb_username
            // 
            txtb_username.Location = new Point(216, 144);
            txtb_username.Name = "txtb_username";
            txtb_username.Size = new Size(262, 27);
            txtb_username.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_submit;
        private Label label3;
        private Label label2;
        private TextBox txtb_pwd;
        private TextBox txtb_username;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
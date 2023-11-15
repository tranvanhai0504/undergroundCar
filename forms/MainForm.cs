using CarApp.Utils;
using CarApp.UserControls;

namespace CarApp
{
    public partial class MainForm : Form
    {
        private DebounceHandler debounceHandler = new DebounceHandler(100);
        public MainForm()
        {
            InitializeComponent();
            if (LoginForm.accountLogined.Role != 0)
            {
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                addUserControl(new UscHome());
            });
            focus_button(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void focus_button(int code)
        {
            button1.ForeColor = Color.FromArgb(0, 91, 65);
            button1.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(0, 91, 65);
            button2.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(0, 91, 65);
            button3.BackColor = Color.White;
            button4.ForeColor = Color.FromArgb(0, 91, 65);
            button4.BackColor = Color.White;
            switch (code)
            {
                case 0:
                    {
                        button1.ForeColor = Color.White;
                        button1.BackColor = Color.FromArgb(0, 91, 65);
                        break;
                    }
                case 1:
                    {
                        button2.ForeColor = Color.White;
                        button2.BackColor = Color.FromArgb(0, 91, 65);
                        break;
                    }
                case 2:
                    {
                        button3.ForeColor = Color.White;
                        button3.BackColor = Color.FromArgb(0, 91, 65);
                        break;
                    }
                case 3:
                    {
                        button4.ForeColor = Color.White;
                        button4.BackColor = Color.FromArgb(0, 91, 65);
                        break;
                    }
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                addUserControl(new UscHome());
            });
            focus_button(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                addUserControl(new UscHire());
            });
            focus_button(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                addUserControl(new UscCarManager());
            });
            focus_button(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            focus_button(1);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            debounceHandler.Debounce(() =>
            {
                addUserControl(new UscCustomerManager());
            });
            focus_button(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm.accountLogined = null;
                LoginForm form = new LoginForm();
                Program.myAppCxt.MainForm = form;
                form.Show();
                this.Close();
            }
        }
    }
}
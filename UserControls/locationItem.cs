using Guna.UI2.WinForms;
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
    public partial class locationItem : UserControl
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscHire));
        private String dataLocationTo;
        private String dataLocationFrom;
        public locationItem(String locationTo, String locationFrom)
        {
            InitializeComponent();
            dataLocationTo = locationTo;
            dataLocationFrom = locationFrom;
            Guna2Panel locationf = renderLocationTag(locationFrom);
            Guna2Panel locationt = renderLocationTag(locationTo);
            PictureBox arrow = new PictureBox();
            arrow.BackgroundImageLayout = ImageLayout.Center;
            arrow.Image = (Image)resources.GetObject("arrowImage.Image");
            arrow.Location = new Point(321, 1014);
            arrow.Name = "arrowImage";
            arrow.Padding = new Padding(0, 10, 0, 0);
            arrow.Size = new Size(53, 45);
            arrow.TabIndex = 19;
            arrow.TabStop = false;

            flowLayoutPanel.Controls.Add(locationf);
            flowLayoutPanel.Controls.Add(arrow);
            flowLayoutPanel.Controls.Add(locationt);

        }

        private Guna2Panel renderLocationTag(String location)
        {
            Guna2Panel locationContainer = new Guna2Panel();
            locationContainer.AllowDrop = true;
            locationContainer.AutoSize = true;
            locationContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            locationContainer.BorderColor = Color.FromArgb(0, 91, 65);
            locationContainer.BorderRadius = 10;
            locationContainer.BorderThickness = 3;
            locationContainer.Cursor = Cursors.Hand;
            locationContainer.Location = new Point(3, 3);
            locationContainer.Margin = new Padding(3, 3, 3, 20);
            locationContainer.MaximumSize = new Size(700, 0);
            locationContainer.Name = "guna2Panel1";
            locationContainer.Padding = new Padding(10);
            locationContainer.Size = new Size(122, 40);
            locationContainer.TabIndex = 19;

            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.FromArgb(0, 91, 65);
            label.Location = new Point(13, 10);
            label.Name = "label5";
            label.Size = new Size(96, 20);
            label.TabIndex = 2;
            label.Text = location;

            locationContainer.Controls.Add((Label)label);
            return locationContainer;
        }

        public List<String> getSchedule()
        {
            List<String> locations = new List<String>()
            {
                dataLocationFrom,
                dataLocationTo,
            };

            return locations;
        }
    }
}

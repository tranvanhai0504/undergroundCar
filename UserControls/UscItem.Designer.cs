namespace CarApp.UserControls
{
    partial class UscItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscItem));
            image = new PictureBox();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // image
            // 
            image.BackgroundImage = (Image)resources.GetObject("image.BackgroundImage");
            image.BackgroundImageLayout = ImageLayout.Center;
            image.Location = new Point(18, 3);
            image.Name = "image";
            image.Size = new Size(120, 73);
            image.TabIndex = 2;
            image.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.Gray;
            label.Location = new Point(26, 89);
            label.Name = "label";
            label.Size = new Size(103, 20);
            label.TabIndex = 3;
            label.Text = "4 chỗ (Sedan)";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UscItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label);
            Controls.Add(image);
            Name = "UscItem";
            Size = new Size(157, 143);
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox image;
        private Label label;
    }
}

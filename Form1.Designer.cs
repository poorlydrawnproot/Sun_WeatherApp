namespace Sun_WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CCAt = new Label();
            locName = new Label();
            currTemp = new Label();
            cheesyFlavorText = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // CCAt
            // 
            CCAt.AutoSize = true;
            CCAt.Font = new Font("Segoe UI", 15F);
            CCAt.Location = new Point(3, 0);
            CCAt.Name = "CCAt";
            CCAt.Size = new Size(302, 41);
            CCAt.TabIndex = 0;
            CCAt.Text = "Current Conditions at";
            // 
            // locName
            // 
            locName.AutoSize = true;
            locName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locName.Location = new Point(311, 0);
            locName.Name = "locName";
            locName.Size = new Size(293, 41);
            locName.TabIndex = 1;
            locName.Text = "Long Location Name";
            locName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // currTemp
            // 
            currTemp.AutoSize = true;
            currTemp.BackColor = SystemColors.Window;
            currTemp.FlatStyle = FlatStyle.Flat;
            currTemp.Font = new Font("Segoe UI", 25F);
            currTemp.Location = new Point(605, 241);
            currTemp.Name = "currTemp";
            currTemp.Size = new Size(157, 67);
            currTemp.TabIndex = 2;
            currTemp.Text = "----°K";
            // 
            // cheesyFlavorText
            // 
            cheesyFlavorText.AutoSize = true;
            cheesyFlavorText.Font = new Font("Segoe UI", 15F);
            cheesyFlavorText.Location = new Point(150, 0);
            cheesyFlavorText.Name = "cheesyFlavorText";
            cheesyFlavorText.RightToLeft = RightToLeft.No;
            cheesyFlavorText.Size = new Size(188, 41);
            cheesyFlavorText.TabIndex = 3;
            cheesyFlavorText.Text = "Now that's toasty!";
            cheesyFlavorText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(CCAt);
            flowLayoutPanel1.Controls.Add(locName);
            flowLayoutPanel1.Location = new Point(15, 29);
            flowLayoutPanel1.Margin = new Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(770, 44);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(cheesyFlavorText);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(430, 308);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(341, 41);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(currTemp);
            Name = "Form1";
            Text = "Sun Weather App";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CCAt;
        private Label locName;
        private Label currTemp;
        private Label cheesyFlavorText;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}

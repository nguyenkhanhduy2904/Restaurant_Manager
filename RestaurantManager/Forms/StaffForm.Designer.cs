namespace RestaurantManager.Forms
{
    partial class StaffForm
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
            lbUserName = new Label();
            btnProfile = new Button();
            btnOrder = new Button();
            btnLogOut = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(27, 22);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(199, 30);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Hello <username>";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(893, 131);
            btnProfile.Margin = new Padding(4, 4, 4, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(300, 200);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Your profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(893, 439);
            btnOrder.Margin = new Padding(4, 4, 4, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(300, 200);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Start Ordering";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(75, 925);
            btnLogOut.Margin = new Padding(4, 4, 4, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(195, 90);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.abstract_background_design_perfect_landing_page_background_other_you_want_288336_2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbUserName);
            panel1.Controls.Add(btnLogOut);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 1024);
            panel1.TabIndex = 4;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnOrder);
            Controls.Add(btnProfile);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StaffForm";
            Text = "StaffFrorm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbUserName;
        private Button btnProfile;
        private Button btnOrder;
        private Button btnLogOut;
        private Panel panel1;
    }
}
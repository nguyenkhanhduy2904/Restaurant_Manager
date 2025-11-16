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
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(29, 26);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(159, 25);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Hello <username>";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(194, 21);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(112, 34);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 650);
            Controls.Add(btnProfile);
            Controls.Add(lbUserName);
            Name = "StaffForm";
            Text = "StaffFrorm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private Button btnProfile;
    }
}
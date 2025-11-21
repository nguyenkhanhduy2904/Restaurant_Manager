namespace RestaurantManager.Forms
{
    partial class SignInForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtBxUserName = new TextBox();
            txtBxPassword = new TextBox();
            btnSignIn = new Button();
            label3 = new Label();
            panel3 = new Panel();
            lbCalendar = new Label();
            lbClock = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1239, 95);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1239, 182);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtBxUserName
            // 
            txtBxUserName.Location = new Point(1355, 96);
            txtBxUserName.Name = "txtBxUserName";
            txtBxUserName.Size = new Size(508, 31);
            txtBxUserName.TabIndex = 2;
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(1355, 181);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(508, 31);
            txtBxPassword.TabIndex = 3;
            txtBxPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.Location = new Point(1726, 280);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(137, 72);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1323, 978);
            label3.Name = "label3";
            label3.Size = new Size(214, 25);
            label3.TabIndex = 7;
            label3.Text = "Need help? Contact us at:";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.abstract_background_design_perfect_landing_page_background_other_you_want_288336_2;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(lbCalendar);
            panel3.Controls.Add(lbClock);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1224, 1024);
            panel3.TabIndex = 15;
            // 
            // lbCalendar
            // 
            lbCalendar.BackColor = Color.Transparent;
            lbCalendar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbCalendar.ForeColor = Color.White;
            lbCalendar.Location = new Point(99, 374);
            lbCalendar.Name = "lbCalendar";
            lbCalendar.Size = new Size(919, 89);
            lbCalendar.TabIndex = 1;
            lbCalendar.Text = "<calendar>";
            lbCalendar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbClock
            // 
            lbClock.AutoSize = true;
            lbClock.BackColor = Color.Transparent;
            lbClock.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lbClock.ForeColor = Color.White;
            lbClock.Location = new Point(280, 142);
            lbClock.Name = "lbClock";
            lbClock.Size = new Size(603, 191);
            lbClock.TabIndex = 0;
            lbClock.Text = "<clock>";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImage = Properties.Resources.images__1_3;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1555, 970);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.BackgroundImage = Properties.Resources.github_mark;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1601, 970);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.BackgroundImage = Properties.Resources._20673;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(1647, 970);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 18;
            button3.UseVisualStyleBackColor = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(btnSignIn);
            Controls.Add(txtBxPassword);
            Controls.Add(txtBxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxUserName;
        private TextBox txtBxPassword;
        private Button btnSignIn;
        private Label label3;
        private Panel panel3;
        private System.Windows.Forms.Timer timerClock;
        private Label lbClock;
        private Label lbCalendar;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
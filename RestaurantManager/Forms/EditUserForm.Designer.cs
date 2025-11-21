namespace RestaurantManager.Forms
{
    partial class EditUserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grBxRole = new GroupBox();
            radStaff = new RadioButton();
            radAdmin = new RadioButton();
            txtBxID = new TextBox();
            txtBxName = new TextBox();
            label4 = new Label();
            txtBxPassword = new TextBox();
            btnSave = new Button();
            btnReturn = new Button();
            panel1 = new Panel();
            lbUserName = new Label();
            grBxRole.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(792, 191);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 30);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(792, 298);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(792, 530);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 3;
            label3.Text = "Role:";
            // 
            // grBxRole
            // 
            grBxRole.Controls.Add(radStaff);
            grBxRole.Controls.Add(radAdmin);
            grBxRole.Location = new Point(1025, 477);
            grBxRole.Margin = new Padding(4, 4, 4, 4);
            grBxRole.Name = "grBxRole";
            grBxRole.Padding = new Padding(4, 4, 4, 4);
            grBxRole.Size = new Size(316, 112);
            grBxRole.TabIndex = 4;
            grBxRole.TabStop = false;
            // 
            // radStaff
            // 
            radStaff.AutoSize = true;
            radStaff.Location = new Point(199, 53);
            radStaff.Margin = new Padding(4, 4, 4, 4);
            radStaff.Name = "radStaff";
            radStaff.Size = new Size(84, 34);
            radStaff.TabIndex = 1;
            radStaff.TabStop = true;
            radStaff.Text = "Staff";
            radStaff.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            radAdmin.AutoSize = true;
            radAdmin.Location = new Point(8, 53);
            radAdmin.Margin = new Padding(4, 4, 4, 4);
            radAdmin.Name = "radAdmin";
            radAdmin.Size = new Size(104, 34);
            radAdmin.TabIndex = 0;
            radAdmin.TabStop = true;
            radAdmin.Text = "Admin";
            radAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(932, 184);
            txtBxID.Margin = new Padding(4, 4, 4, 4);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(479, 37);
            txtBxID.TabIndex = 5;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(932, 291);
            txtBxName.Margin = new Padding(4, 4, 4, 4);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(479, 37);
            txtBxName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(792, 398);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(932, 395);
            txtBxPassword.Margin = new Padding(4, 4, 4, 4);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(479, 37);
            txtBxPassword.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1217, 649);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 64);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(75, 925);
            btnReturn.Margin = new Padding(4, 4, 4, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(195, 90);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.abstract_background_design_perfect_landing_page_background_other_you_want_288336_2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbUserName);
            panel1.Controls.Add(btnReturn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 1024);
            panel1.TabIndex = 11;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(30, 24);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(179, 38);
            lbUserName.TabIndex = 11;
            lbUserName.Text = "<username>";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(txtBxPassword);
            Controls.Add(label4);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(grBxRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EditUserForm";
            Text = "EditUserForm";
            grBxRole.ResumeLayout(false);
            grBxRole.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox grBxRole;
        private RadioButton radStaff;
        private RadioButton radAdmin;
        private TextBox txtBxID;
        private TextBox txtBxName;
        private Label label4;
        private TextBox txtBxPassword;
        private Button btnSave;
        private Button btnReturn;
        private Panel panel1;
        private Label lbUserName;
    }
}
namespace RestaurantManager.Forms
{
    partial class AdminForm
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
            btnManageUsers = new Button();
            btnManageProducts = new Button();
            btnManageCategories = new Button();
            lbUserName = new Label();
            btnLogout = new Button();
            btnManageTableType = new Button();
            btnManageTable = new Button();
            panel1 = new Panel();
            cbxRevenue = new ComboBox();
            panel2 = new Panel();
            lbTotalRevenue = new Label();
            lbTimeStampTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            cbxBestSell = new ComboBox();
            panel3 = new Panel();
            lbBestSell3 = new Label();
            lbBestSell2 = new Label();
            lbBestSell1 = new Label();
            lbTimeStampSelling = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(1112, 626);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(250, 175);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.Location = new Point(500, 837);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(250, 175);
            btnManageProducts.TabIndex = 1;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = true;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Location = new Point(500, 626);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(250, 175);
            btnManageCategories.TabIndex = 2;
            btnManageCategories.Text = "Manage Categories";
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(12, 21);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(261, 38);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "Hello, <username>";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(75, 925);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 75);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageTableType
            // 
            btnManageTableType.Location = new Point(811, 626);
            btnManageTableType.Name = "btnManageTableType";
            btnManageTableType.Size = new Size(250, 175);
            btnManageTableType.TabIndex = 5;
            btnManageTableType.Text = "Manage Table Type";
            btnManageTableType.UseVisualStyleBackColor = true;
            btnManageTableType.Click += btnManageTableType_Click;
            // 
            // btnManageTable
            // 
            btnManageTable.Location = new Point(811, 837);
            btnManageTable.Name = "btnManageTable";
            btnManageTable.Size = new Size(250, 175);
            btnManageTable.TabIndex = 6;
            btnManageTable.Text = "Manage Tables";
            btnManageTable.UseVisualStyleBackColor = true;
            btnManageTable.Click += btnManageTable_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BackgroundImage = Properties.Resources.abstract_background_design_perfect_landing_page_background_other_you_want_288336_2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbUserName);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 1024);
            panel1.TabIndex = 7;
            // 
            // cbxRevenue
            // 
            cbxRevenue.FormattingEnabled = true;
            cbxRevenue.Location = new Point(664, 62);
            cbxRevenue.Name = "cbxRevenue";
            cbxRevenue.Size = new Size(182, 33);
            cbxRevenue.TabIndex = 8;
            cbxRevenue.SelectedIndexChanged += cbxRevenue_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbTotalRevenue);
            panel2.Controls.Add(lbTimeStampTotal);
            panel2.Location = new Point(500, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 220);
            panel2.TabIndex = 9;
            // 
            // lbTotalRevenue
            // 
            lbTotalRevenue.AutoSize = true;
            lbTotalRevenue.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTotalRevenue.Location = new Point(164, 114);
            lbTotalRevenue.Name = "lbTotalRevenue";
            lbTotalRevenue.Size = new Size(82, 45);
            lbTotalRevenue.TabIndex = 1;
            lbTotalRevenue.Text = "<0>";
            // 
            // lbTimeStampTotal
            // 
            lbTimeStampTotal.AutoSize = true;
            lbTimeStampTotal.Location = new Point(27, 18);
            lbTimeStampTotal.Name = "lbTimeStampTotal";
            lbTimeStampTotal.Size = new Size(126, 25);
            lbTimeStampTotal.TabIndex = 0;
            lbTimeStampTotal.Text = "<time stamp>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(500, 65);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 10;
            label1.Text = "Total Revenue:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1206, 65);
            label2.Name = "label2";
            label2.Size = new Size(156, 30);
            label2.TabIndex = 11;
            label2.Text = "Best selling in:";
            // 
            // cbxBestSell
            // 
            cbxBestSell.FormattingEnabled = true;
            cbxBestSell.Location = new Point(1368, 62);
            cbxBestSell.Name = "cbxBestSell";
            cbxBestSell.Size = new Size(182, 33);
            cbxBestSell.TabIndex = 12;
            cbxBestSell.SelectedIndexChanged += cbxBestSell_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbBestSell3);
            panel3.Controls.Add(lbBestSell2);
            panel3.Controls.Add(lbBestSell1);
            panel3.Controls.Add(lbTimeStampSelling);
            panel3.Location = new Point(1209, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(654, 220);
            panel3.TabIndex = 10;
            // 
            // lbBestSell3
            // 
            lbBestSell3.AutoSize = true;
            lbBestSell3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBestSell3.Location = new Point(60, 143);
            lbBestSell3.Name = "lbBestSell3";
            lbBestSell3.Size = new Size(35, 45);
            lbBestSell3.TabIndex = 3;
            lbBestSell3.Text = "3";
            // 
            // lbBestSell2
            // 
            lbBestSell2.AutoSize = true;
            lbBestSell2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBestSell2.Location = new Point(60, 98);
            lbBestSell2.Name = "lbBestSell2";
            lbBestSell2.Size = new Size(36, 45);
            lbBestSell2.TabIndex = 2;
            lbBestSell2.Text = "2";
            // 
            // lbBestSell1
            // 
            lbBestSell1.AutoSize = true;
            lbBestSell1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBestSell1.Location = new Point(61, 53);
            lbBestSell1.Name = "lbBestSell1";
            lbBestSell1.Size = new Size(33, 45);
            lbBestSell1.TabIndex = 1;
            lbBestSell1.Text = "1";
            // 
            // lbTimeStampSelling
            // 
            lbTimeStampSelling.AutoSize = true;
            lbTimeStampSelling.Location = new Point(27, 18);
            lbTimeStampSelling.Name = "lbTimeStampSelling";
            lbTimeStampSelling.Size = new Size(126, 25);
            lbTimeStampSelling.TabIndex = 0;
            lbTimeStampSelling.Text = "<time stamp>";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel3);
            Controls.Add(cbxBestSell);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(cbxRevenue);
            Controls.Add(panel1);
            Controls.Add(btnManageTable);
            Controls.Add(btnManageTableType);
            Controls.Add(btnManageCategories);
            Controls.Add(btnManageProducts);
            Controls.Add(btnManageUsers);
            Name = "AdminForm";
            Text = "AdminForm";
            Activated += AdminForm_Activated;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageUsers;
        private Button btnManageProducts;
        private Button btnManageCategories;
        private Label lbUserName;
        private Button btnLogout;
        private Button btnManageTableType;
        private Button btnManageTable;
        private Panel panel1;
        private ComboBox cbxRevenue;
        private Panel panel2;
        private Label lbTimeStampTotal;
        private Label label1;
        private Label lbTotalRevenue;
        private Label label2;
        private ComboBox cbxBestSell;
        private Panel panel3;
        private Label lbBestSell1;
        private Label lbTimeStampSelling;
        private Label lbBestSell3;
        private Label lbBestSell2;
    }
}
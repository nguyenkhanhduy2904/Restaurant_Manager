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
            SuspendLayout();
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(509, 93);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(152, 34);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.Location = new Point(509, 146);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(163, 34);
            btnManageProducts.TabIndex = 1;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = true;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Location = new Point(509, 198);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(186, 34);
            btnManageCategories.TabIndex = 2;
            btnManageCategories.Text = "Manage Categories";
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(30, 22);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(163, 25);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "Hello, <username>";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(30, 581);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageTableType
            // 
            btnManageTableType.Location = new Point(509, 253);
            btnManageTableType.Name = "btnManageTableType";
            btnManageTableType.Size = new Size(186, 34);
            btnManageTableType.TabIndex = 5;
            btnManageTableType.Text = "Manage Table Type";
            btnManageTableType.UseVisualStyleBackColor = true;
            btnManageTableType.Click += btnManageTableType_Click;
            // 
            // btnManageTable
            // 
            btnManageTable.Location = new Point(509, 314);
            btnManageTable.Name = "btnManageTable";
            btnManageTable.Size = new Size(186, 34);
            btnManageTable.TabIndex = 6;
            btnManageTable.Text = "Manage Tables";
            btnManageTable.UseVisualStyleBackColor = true;
            btnManageTable.Click += btnManageTable_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 879);
            Controls.Add(btnManageTable);
            Controls.Add(btnManageTableType);
            Controls.Add(btnLogout);
            Controls.Add(lbUserName);
            Controls.Add(btnManageCategories);
            Controls.Add(btnManageProducts);
            Controls.Add(btnManageUsers);
            Name = "AdminForm";
            Text = "AdminForm";
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
    }
}
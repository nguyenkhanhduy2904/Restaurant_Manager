namespace RestaurantManager.Forms
{
    partial class ManageUsersForm
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
            dgvUsersList = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnResetPassword = new Button();
            lbUserName = new Label();
            btnReturn = new Button();
            btnCreate = new Button();
            panel1 = new Panel();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsersList.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colRole });
            dgvUsersList.Location = new Point(513, 159);
            dgvUsersList.Margin = new Padding(4, 4, 4, 4);
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.ReadOnly = true;
            dgvUsersList.RowHeadersWidth = 62;
            dgvUsersList.RowTemplate.Height = 33;
            dgvUsersList.Size = new Size(1085, 783);
            dgvUsersList.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1651, 364);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 100);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1651, 511);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 100);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(1651, 658);
            btnResetPassword.Margin = new Padding(4, 4, 4, 4);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(150, 100);
            btnResetPassword.TabIndex = 3;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(27, 23);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(140, 30);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "<username>";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(75, 925);
            btnReturn.Margin = new Padding(4, 4, 4, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(195, 90);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1651, 223);
            btnCreate.Margin = new Padding(4, 4, 4, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 100);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.abstract_background_design_perfect_landing_page_background_other_you_want_288336_2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(lbUserName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 1024);
            panel1.TabIndex = 7;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 150;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 500;
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 8;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 500;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnCreate);
            Controls.Add(btnResetPassword);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvUsersList);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            Activated += ManageUsersForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsersList;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnResetPassword;
        private Label lbUserName;
        private Button btnReturn;
        private Button btnCreate;
        private Panel panel1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colRole;
    }
}
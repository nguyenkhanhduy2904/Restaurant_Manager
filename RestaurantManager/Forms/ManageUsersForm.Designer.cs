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
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            btnResetPassword = new Button();
            lbUserName = new Label();
            btnReturn = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            SuspendLayout();
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsersList.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colRole });
            dgvUsersList.Location = new Point(323, 190);
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.ReadOnly = true;
            dgvUsersList.RowHeadersWidth = 62;
            dgvUsersList.RowTemplate.Height = 33;
            dgvUsersList.Size = new Size(580, 225);
            dgvUsersList.TabIndex = 0;
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
            colName.Width = 150;
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 8;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 150;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(988, 255);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(988, 317);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(988, 381);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(144, 34);
            btnResetPassword.TabIndex = 3;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(45, 29);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(113, 25);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "<username>";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(114, 529);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(988, 190);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 34);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 629);
            Controls.Add(btnCreate);
            Controls.Add(btnReturn);
            Controls.Add(lbUserName);
            Controls.Add(btnResetPassword);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvUsersList);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            Activated += ManageUsersForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsersList;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colRole;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnResetPassword;
        private Label lbUserName;
        private Button btnReturn;
        private Button btnCreate;
    }
}
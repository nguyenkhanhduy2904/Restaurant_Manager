namespace RestaurantManager.Forms
{
    partial class ManageCategoriesForm
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
            dgvCategoriesList = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            btnReturn = new Button();
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).BeginInit();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(25, 9);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(113, 25);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "<username>";
            // 
            // dgvCategoriesList
            // 
            dgvCategoriesList.AllowUserToAddRows = false;
            dgvCategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriesList.Columns.AddRange(new DataGridViewColumn[] { colID, colName });
            dgvCategoriesList.Location = new Point(199, 157);
            dgvCategoriesList.Name = "dgvCategoriesList";
            dgvCategoriesList.ReadOnly = true;
            dgvCategoriesList.RowHeadersWidth = 62;
            dgvCategoriesList.RowTemplate.Height = 33;
            dgvCategoriesList.Size = new Size(530, 225);
            dgvCategoriesList.TabIndex = 1;
            // 
            // colID
            // 
            colID.HeaderText = "ID:";
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
            // btnReturn
            // 
            btnReturn.Location = new Point(81, 531);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(796, 162);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(796, 211);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(796, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ManageCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 633);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(btnReturn);
            Controls.Add(dgvCategoriesList);
            Controls.Add(lbUserName);
            Name = "ManageCategoriesForm";
            Text = "ManageCategoriesForm";
            Activated += ManageCategoriesForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private DataGridView dgvCategoriesList;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private Button btnReturn;
        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
    }
}
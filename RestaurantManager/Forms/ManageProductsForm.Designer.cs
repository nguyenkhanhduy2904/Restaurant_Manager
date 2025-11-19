namespace RestaurantManager.Forms
{
    partial class ManageProductsForm
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
            dgvProductsList = new DataGridView();
            col1 = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colIsAvailable = new DataGridViewTextBoxColumn();
            lbUserName = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnReturn = new Button();
            btnDisable = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).BeginInit();
            SuspendLayout();
            // 
            // dgvProductsList
            // 
            dgvProductsList.AllowUserToAddRows = false;
            dgvProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsList.Columns.AddRange(new DataGridViewColumn[] { col1, colName, colPrice, colCategory, colIsAvailable });
            dgvProductsList.Location = new Point(103, 106);
            dgvProductsList.Name = "dgvProductsList";
            dgvProductsList.RowHeadersWidth = 62;
            dgvProductsList.RowTemplate.Height = 33;
            dgvProductsList.Size = new Size(917, 225);
            dgvProductsList.TabIndex = 0;
            // 
            // col1
            // 
            col1.HeaderText = "ID";
            col1.MinimumWidth = 8;
            col1.Name = "col1";
            col1.ReadOnly = true;
            col1.Width = 150;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 150;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 150;
            // 
            // colIsAvailable
            // 
            colIsAvailable.HeaderText = "Available";
            colIsAvailable.MinimumWidth = 8;
            colIsAvailable.Name = "colIsAvailable";
            colIsAvailable.ReadOnly = true;
            colIsAvailable.Width = 150;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(59, 30);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(113, 25);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "<username>";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1092, 104);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1092, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1092, 220);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(103, 445);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnDisable
            // 
            btnDisable.Location = new Point(1092, 283);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(112, 34);
            btnDisable.TabIndex = 6;
            btnDisable.Text = "Disable";
            btnDisable.UseVisualStyleBackColor = true;
            // 
            // ManageProductsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 525);
            Controls.Add(btnDisable);
            Controls.Add(btnReturn);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(lbUserName);
            Controls.Add(dgvProductsList);
            Name = "ManageProductsForm";
            Text = "ManageProductsForm";
            Activated += ManageProductsForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductsList;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colIsAvailable;
        private Label lbUserName;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnReturn;
        private Button btnDisable;
    }
}
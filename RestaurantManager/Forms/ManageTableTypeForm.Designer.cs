namespace RestaurantManager.Forms
{
    partial class ManageTableTypeForm
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
            dgvTableType = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            btnCreateNew = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnReturn = new Button();
            lbUserName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTableType).BeginInit();
            SuspendLayout();
            // 
            // dgvTableType
            // 
            dgvTableType.AllowUserToAddRows = false;
            dgvTableType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableType.Columns.AddRange(new DataGridViewColumn[] { colID, colName });
            dgvTableType.Location = new Point(170, 64);
            dgvTableType.Name = "dgvTableType";
            dgvTableType.RowHeadersWidth = 62;
            dgvTableType.RowTemplate.Height = 33;
            dgvTableType.Size = new Size(360, 225);
            dgvTableType.TabIndex = 0;
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
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(738, 64);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(112, 34);
            btnCreateNew.TabIndex = 1;
            btnCreateNew.Text = "Create New";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(738, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(738, 200);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(161, 361);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(23, 12);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(113, 25);
            lbUserName.TabIndex = 5;
            lbUserName.Text = "<username>";
            // 
            // ManageTableTypeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 450);
            Controls.Add(lbUserName);
            Controls.Add(btnReturn);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnCreateNew);
            Controls.Add(dgvTableType);
            Name = "ManageTableTypeForm";
            Text = "ManageTableTypeForm";
            Activated += ManageTableTypeForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvTableType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTableType;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private Button btnCreateNew;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnReturn;
        private Label lbUserName;
    }
}
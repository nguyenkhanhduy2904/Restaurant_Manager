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
            lbUserName = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnReturn = new Button();
            panel1 = new Panel();
            col1 = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colIsAvailable = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductsList
            // 
            dgvProductsList.AllowUserToAddRows = false;
            dgvProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsList.Columns.AddRange(new DataGridViewColumn[] { col1, colName, colPrice, colCategory, colIsAvailable });
            dgvProductsList.Location = new Point(513, 208);
            dgvProductsList.Margin = new Padding(4, 4, 4, 4);
            dgvProductsList.Name = "dgvProductsList";
            dgvProductsList.RowHeadersWidth = 62;
            dgvProductsList.RowTemplate.Height = 33;
            dgvProductsList.Size = new Size(1135, 648);
            dgvProductsList.TabIndex = 0;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(42, 27);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(140, 30);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "<username>";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1693, 252);
            btnCreate.Margin = new Padding(4, 4, 4, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 100);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1693, 399);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 100);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1693, 576);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 100);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
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
            panel1.TabIndex = 7;
            // 
            // col1
            // 
            col1.HeaderText = "ID";
            col1.MinimumWidth = 8;
            col1.Name = "col1";
            col1.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 250;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 250;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 250;
            // 
            // colIsAvailable
            // 
            colIsAvailable.HeaderText = "Available";
            colIsAvailable.MinimumWidth = 8;
            colIsAvailable.Name = "colIsAvailable";
            colIsAvailable.ReadOnly = true;
            colIsAvailable.Width = 250;
            // 
            // ManageProductsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dgvProductsList);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ManageProductsForm";
            Text = "ManageProductsForm";
            Activated += ManageProductsForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductsList;
        private Label lbUserName;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnReturn;
        private Panel panel1;
        private DataGridViewTextBoxColumn col1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colIsAvailable;
    }
}
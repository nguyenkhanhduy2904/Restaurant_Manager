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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(40, 23);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(179, 38);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "<username>";
            // 
            // dgvCategoriesList
            // 
            dgvCategoriesList.AllowUserToAddRows = false;
            dgvCategoriesList.AllowUserToDeleteRows = false;
            dgvCategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriesList.Columns.AddRange(new DataGridViewColumn[] { colID, colName });
            dgvCategoriesList.Location = new Point(483, 154);
            dgvCategoriesList.Name = "dgvCategoriesList";
            dgvCategoriesList.ReadOnly = true;
            dgvCategoriesList.RowHeadersWidth = 62;
            dgvCategoriesList.RowTemplate.Height = 33;
            dgvCategoriesList.Size = new Size(958, 649);
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
            colName.Width = 750;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Location = new Point(75, 925);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(150, 75);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCreate
            // 
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(1556, 154);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(250, 175);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create New";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(1556, 398);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(250, 175);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1556, 628);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 175);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            panel1.TabIndex = 6;
            // 
            // ManageCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(dgvCategoriesList);
            ForeColor = Color.Black;
            Name = "ManageCategoriesForm";
            Text = "ManageCategoriesForm";
            Activated += ManageCategoriesForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbUserName;
        private DataGridView dgvCategoriesList;
        private Button btnReturn;
        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
        private Panel panel1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
    }
}
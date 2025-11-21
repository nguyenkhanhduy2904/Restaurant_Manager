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
            btnCreateNew = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnReturn = new Button();
            lbUserName = new Label();
            panel1 = new Panel();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTableType).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTableType
            // 
            dgvTableType.AllowUserToAddRows = false;
            dgvTableType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableType.Columns.AddRange(new DataGridViewColumn[] { colID, colName });
            dgvTableType.Location = new Point(521, 154);
            dgvTableType.Margin = new Padding(4, 4, 4, 4);
            dgvTableType.Name = "dgvTableType";
            dgvTableType.RowHeadersWidth = 62;
            dgvTableType.RowTemplate.Height = 33;
            dgvTableType.Size = new Size(1121, 771);
            dgvTableType.TabIndex = 0;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(1712, 315);
            btnCreateNew.Margin = new Padding(4, 4, 4, 4);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(150, 100);
            btnCreateNew.TabIndex = 1;
            btnCreateNew.Text = "Create New";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1712, 505);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 100);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1712, 689);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 100);
            btnEdit.TabIndex = 3;
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
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(13, 22);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(140, 30);
            lbUserName.TabIndex = 5;
            lbUserName.Text = "<username>";
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
            panel1.TabIndex = 6;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 250;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 850;
            // 
            // ManageTableTypeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnCreateNew);
            Controls.Add(dgvTableType);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ManageTableTypeForm";
            Text = "ManageTableTypeForm";
            Activated += ManageTableTypeForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvTableType).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTableType;
        private Button btnCreateNew;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnReturn;
        private Label lbUserName;
        private Panel panel1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
    }
}
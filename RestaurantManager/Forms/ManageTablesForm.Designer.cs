namespace RestaurantManager.Forms
{
    partial class ManageTablesForm
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
            flpTables = new FlowLayoutPanel();
            btnCreate = new Button();
            btnReturn = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            lbUserName = new Label();
            SuspendLayout();
            // 
            // flpTables
            // 
            flpTables.AutoScroll = true;
            flpTables.Dock = DockStyle.Bottom;
            flpTables.Location = new Point(0, 182);
            flpTables.Margin = new Padding(4);
            flpTables.Name = "flpTables";
            flpTables.Size = new Size(1898, 842);
            flpTables.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1267, 77);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 74);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Tables";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(13, 76);
            btnReturn.Margin = new Padding(4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(146, 75);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1518, 77);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 74);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1713, 77);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 74);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(13, 27);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(140, 30);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "<username>";
            // 
            // ManageTablesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(lbUserName);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnReturn);
            Controls.Add(btnCreate);
            Controls.Add(flpTables);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ManageTablesForm";
            Text = "ManageTablesForm";
            Activated += ManageTablesForm_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpTables;
        private Button btnCreate;
        private Button btnReturn;
        private Button btnDelete;
        private Button btnEdit;
        private Label lbUserName;
    }
}
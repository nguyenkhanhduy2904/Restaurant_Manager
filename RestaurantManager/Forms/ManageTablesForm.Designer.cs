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
            flpTables.Location = new Point(0, 514);
            flpTables.Name = "flpTables";
            flpTables.Size = new Size(1314, 474);
            flpTables.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(695, 63);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(154, 34);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Tables";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(34, 63);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(892, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1034, 63);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(64, 19);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(113, 25);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "<username>";
            // 
            // ManageTablesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 988);
            Controls.Add(lbUserName);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnReturn);
            Controls.Add(btnCreate);
            Controls.Add(flpTables);
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
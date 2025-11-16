namespace RestaurantManager.Forms
{
    partial class EditUserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grBxRole = new GroupBox();
            radStaff = new RadioButton();
            radAdmin = new RadioButton();
            txtBxID = new TextBox();
            txtBxName = new TextBox();
            label4 = new Label();
            txtBxPassword = new TextBox();
            btnSave = new Button();
            btnReturn = new Button();
            grBxRole.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 30);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 79);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 194);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 3;
            label3.Text = "Role:";
            // 
            // grBxRole
            // 
            grBxRole.Controls.Add(radStaff);
            grBxRole.Controls.Add(radAdmin);
            grBxRole.Location = new Point(173, 179);
            grBxRole.Name = "grBxRole";
            grBxRole.Size = new Size(243, 93);
            grBxRole.TabIndex = 4;
            grBxRole.TabStop = false;
            // 
            // radStaff
            // 
            radStaff.AutoSize = true;
            radStaff.Location = new Point(153, 44);
            radStaff.Name = "radStaff";
            radStaff.Size = new Size(73, 29);
            radStaff.TabIndex = 1;
            radStaff.TabStop = true;
            radStaff.Text = "Staff";
            radStaff.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            radAdmin.AutoSize = true;
            radAdmin.Location = new Point(6, 44);
            radAdmin.Name = "radAdmin";
            radAdmin.Size = new Size(90, 29);
            radAdmin.TabIndex = 0;
            radAdmin.TabStop = true;
            radAdmin.Text = "Admin";
            radAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(173, 30);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(237, 31);
            txtBxID.TabIndex = 5;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(173, 79);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(237, 31);
            txtBxName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 136);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // txtBxPassword
            // 
            txtBxPassword.Location = new Point(173, 133);
            txtBxPassword.Name = "txtBxPassword";
            txtBxPassword.Size = new Size(237, 31);
            txtBxPassword.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(326, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(103, 392);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 535);
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(txtBxPassword);
            Controls.Add(label4);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(grBxRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUserForm";
            Text = "EditUserForm";
            grBxRole.ResumeLayout(false);
            grBxRole.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox grBxRole;
        private RadioButton radStaff;
        private RadioButton radAdmin;
        private TextBox txtBxID;
        private TextBox txtBxName;
        private Label label4;
        private TextBox txtBxPassword;
        private Button btnSave;
        private Button btnReturn;
    }
}
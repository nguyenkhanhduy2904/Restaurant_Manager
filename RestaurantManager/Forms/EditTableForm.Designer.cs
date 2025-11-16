namespace RestaurantManager.Forms
{
    partial class EditTableForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            radTrue = new RadioButton();
            radFalse = new RadioButton();
            dgvOrder = new DataGridView();
            label4 = new Label();
            txtBxOrderID = new TextBox();
            label5 = new Label();
            lbTimeCreate = new Label();
            label6 = new Label();
            lbCreateByUser = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 130);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Table Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 69);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radFalse);
            groupBox1.Controls.Add(radTrue);
            groupBox1.Location = new Point(182, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 150);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 217);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 5;
            label3.Text = "Is Ocupied:";
            // 
            // radTrue
            // 
            radTrue.AutoSize = true;
            radTrue.Location = new Point(19, 47);
            radTrue.Name = "radTrue";
            radTrue.Size = new Size(69, 29);
            radTrue.TabIndex = 0;
            radTrue.TabStop = true;
            radTrue.Text = "True";
            radTrue.UseVisualStyleBackColor = true;
            // 
            // radFalse
            // 
            radFalse.AutoSize = true;
            radFalse.Location = new Point(133, 47);
            radFalse.Name = "radFalse";
            radFalse.Size = new Size(75, 29);
            radFalse.TabIndex = 1;
            radFalse.TabStop = true;
            radFalse.Text = "False";
            radFalse.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(810, 155);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(360, 225);
            dgvOrder.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(810, 45);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 7;
            label4.Text = "OrderID:";
            // 
            // txtBxOrderID
            // 
            txtBxOrderID.Enabled = false;
            txtBxOrderID.Location = new Point(927, 45);
            txtBxOrderID.Name = "txtBxOrderID";
            txtBxOrderID.Size = new Size(150, 31);
            txtBxOrderID.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 474);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 9;
            label5.Text = "Time Create:";
            // 
            // lbTimeCreate
            // 
            lbTimeCreate.AutoSize = true;
            lbTimeCreate.Location = new Point(201, 474);
            lbTimeCreate.Name = "lbTimeCreate";
            lbTimeCreate.Size = new Size(71, 25);
            lbTimeCreate.TabIndex = 10;
            lbTimeCreate.Text = "<time>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 543);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 11;
            label6.Text = "Create By:";
            // 
            // lbCreateByUser
            // 
            lbCreateByUser.AutoSize = true;
            lbCreateByUser.Location = new Point(201, 543);
            lbCreateByUser.Name = "lbCreateByUser";
            lbCreateByUser.Size = new Size(69, 25);
            lbCreateByUser.TabIndex = 12;
            lbCreateByUser.Text = "<user>";
            // 
            // EditTableForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 686);
            Controls.Add(lbCreateByUser);
            Controls.Add(label6);
            Controls.Add(lbTimeCreate);
            Controls.Add(label5);
            Controls.Add(txtBxOrderID);
            Controls.Add(label4);
            Controls.Add(dgvOrder);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditTableForm";
            Text = "EditTableForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label label3;
        private RadioButton radFalse;
        private RadioButton radTrue;
        private DataGridView dgvOrder;
        private Label label4;
        private TextBox txtBxOrderID;
        private Label label5;
        private Label lbTimeCreate;
        private Label label6;
        private Label lbCreateByUser;
    }
}
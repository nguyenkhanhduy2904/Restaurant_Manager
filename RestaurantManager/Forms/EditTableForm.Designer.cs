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
            txtBxID = new TextBox();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            radFalse = new RadioButton();
            radTrue = new RadioButton();
            label3 = new Label();
            dgvOrder = new DataGridView();
            label4 = new Label();
            txtBxOrderID = new TextBox();
            label5 = new Label();
            lbTimeCreate = new Label();
            label6 = new Label();
            lbCreateByUser = new Label();
            flpProdCategory = new FlowLayoutPanel();
            flpProd = new FlowLayoutPanel();
            btnReturn = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnPaid = new Button();
            lbTotalPrice = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1053, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 0;
            label1.Text = "Table Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1053, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 30);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(1186, 11);
            txtBxID.Margin = new Padding(4, 4, 4, 4);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(194, 37);
            txtBxID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(1186, 71);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 37);
            txtName.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radFalse);
            groupBox1.Controls.Add(radTrue);
            groupBox1.Location = new Point(1418, 48);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(209, 72);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // radFalse
            // 
            radFalse.AutoSize = true;
            radFalse.Location = new Point(105, 20);
            radFalse.Margin = new Padding(4, 4, 4, 4);
            radFalse.Name = "radFalse";
            radFalse.Size = new Size(86, 34);
            radFalse.TabIndex = 1;
            radFalse.TabStop = true;
            radFalse.Text = "False";
            radFalse.UseVisualStyleBackColor = true;
            // 
            // radTrue
            // 
            radTrue.AutoSize = true;
            radTrue.Location = new Point(8, 20);
            radTrue.Margin = new Padding(4, 4, 4, 4);
            radTrue.Name = "radTrue";
            radTrue.Size = new Size(81, 34);
            radTrue.TabIndex = 0;
            radTrue.TabStop = true;
            radTrue.Text = "True";
            radTrue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1418, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 5;
            label3.Text = "Is Ocupied:";
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(1053, 218);
            dgvOrder.Margin = new Padding(4, 4, 4, 4);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(468, 710);
            dgvOrder.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1053, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 7;
            label4.Text = "OrderID:";
            // 
            // txtBxOrderID
            // 
            txtBxOrderID.Enabled = false;
            txtBxOrderID.Location = new Point(1186, 142);
            txtBxOrderID.Margin = new Padding(4, 4, 4, 4);
            txtBxOrderID.Name = "txtBxOrderID";
            txtBxOrderID.Size = new Size(194, 37);
            txtBxOrderID.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1652, 218);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 30);
            label5.TabIndex = 9;
            label5.Text = "Time Create:";
            // 
            // lbTimeCreate
            // 
            lbTimeCreate.AutoSize = true;
            lbTimeCreate.Location = new Point(1674, 266);
            lbTimeCreate.Margin = new Padding(4, 0, 4, 0);
            lbTimeCreate.Name = "lbTimeCreate";
            lbTimeCreate.Size = new Size(88, 30);
            lbTimeCreate.TabIndex = 10;
            lbTimeCreate.Text = "<time>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1652, 310);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 30);
            label6.TabIndex = 11;
            label6.Text = "Create By:";
            // 
            // lbCreateByUser
            // 
            lbCreateByUser.AutoSize = true;
            lbCreateByUser.Location = new Point(1674, 355);
            lbCreateByUser.Margin = new Padding(4, 0, 4, 0);
            lbCreateByUser.Name = "lbCreateByUser";
            lbCreateByUser.Size = new Size(85, 30);
            lbCreateByUser.TabIndex = 12;
            lbCreateByUser.Text = "<user>";
            // 
            // flpProdCategory
            // 
            flpProdCategory.AutoScroll = true;
            flpProdCategory.Location = new Point(16, 11);
            flpProdCategory.Margin = new Padding(4, 4, 4, 4);
            flpProdCategory.Name = "flpProdCategory";
            flpProdCategory.Size = new Size(1005, 180);
            flpProdCategory.TabIndex = 13;
            // 
            // flpProd
            // 
            flpProd.AutoScroll = true;
            flpProd.Location = new Point(16, 218);
            flpProd.Margin = new Padding(4, 4, 4, 4);
            flpProd.Name = "flpProd";
            flpProd.Size = new Size(1005, 810);
            flpProd.TabIndex = 14;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(1652, 613);
            btnReturn.Margin = new Padding(4, 4, 4, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(146, 69);
            btnReturn.TabIndex = 15;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1652, 523);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 59);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1652, 710);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 70);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnPaid
            // 
            btnPaid.Location = new Point(1652, 935);
            btnPaid.Margin = new Padding(4, 4, 4, 4);
            btnPaid.Name = "btnPaid";
            btnPaid.Size = new Size(146, 65);
            btnPaid.TabIndex = 18;
            btnPaid.Text = "Paid";
            btnPaid.UseVisualStyleBackColor = true;
            btnPaid.Click += btnPaid_Click;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(1383, 946);
            lbTotalPrice.Margin = new Padding(4, 0, 4, 0);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(25, 30);
            lbTotalPrice.TabIndex = 19;
            lbTotalPrice.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1186, 946);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 30);
            label7.TabIndex = 20;
            label7.Text = "Total Price:";
            // 
            // EditTableForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(label7);
            Controls.Add(lbTotalPrice);
            Controls.Add(btnPaid);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnReturn);
            Controls.Add(flpProd);
            Controls.Add(flpProdCategory);
            Controls.Add(lbCreateByUser);
            Controls.Add(label6);
            Controls.Add(lbTimeCreate);
            Controls.Add(label5);
            Controls.Add(txtBxOrderID);
            Controls.Add(label4);
            Controls.Add(dgvOrder);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txtName);
            Controls.Add(txtBxID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EditTableForm";
            Text = "EditTableForm";
            Activated += EditTableForm_Activated;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBxID;
        private TextBox txtName;
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
        private FlowLayoutPanel flpProdCategory;
        private FlowLayoutPanel flpProd;
        private Button btnReturn;
        private Button btnSave;
        private Button btnEdit;
        private Button btnPaid;
        private Label lbTotalPrice;
        private Label label7;
    }
}
namespace RestaurantManager.Forms
{
    partial class EditProductForm
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
            label4 = new Label();
            label5 = new Label();
            lbUserName = new Label();
            txtBxID = new TextBox();
            txtBxName = new TextBox();
            txtBxPrice = new TextBox();
            cbxCategory = new ComboBox();
            grBxIsAvailable = new GroupBox();
            radFalse = new RadioButton();
            radTrue = new RadioButton();
            btnReturn = new Button();
            btnSave = new Button();
            grBxIsAvailable.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 71);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 118);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 164);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 233);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 336);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 4;
            label5.Text = "isAvailable";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(43, 18);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(113, 25);
            lbUserName.TabIndex = 5;
            lbUserName.Text = "<username>";
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(280, 71);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(254, 31);
            txtBxID.TabIndex = 6;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(280, 118);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(254, 31);
            txtBxName.TabIndex = 7;
            // 
            // txtBxPrice
            // 
            txtBxPrice.Location = new Point(280, 164);
            txtBxPrice.Name = "txtBxPrice";
            txtBxPrice.Size = new Size(150, 31);
            txtBxPrice.TabIndex = 8;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(280, 233);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(182, 33);
            cbxCategory.TabIndex = 9;
            // 
            // grBxIsAvailable
            // 
            grBxIsAvailable.Controls.Add(radFalse);
            grBxIsAvailable.Controls.Add(radTrue);
            grBxIsAvailable.Location = new Point(280, 289);
            grBxIsAvailable.Name = "grBxIsAvailable";
            grBxIsAvailable.Size = new Size(300, 94);
            grBxIsAvailable.TabIndex = 10;
            grBxIsAvailable.TabStop = false;
            // 
            // radFalse
            // 
            radFalse.AutoSize = true;
            radFalse.Location = new Point(159, 47);
            radFalse.Name = "radFalse";
            radFalse.Size = new Size(75, 29);
            radFalse.TabIndex = 1;
            radFalse.TabStop = true;
            radFalse.Text = "False";
            radFalse.UseVisualStyleBackColor = true;
            // 
            // radTrue
            // 
            radTrue.AutoSize = true;
            radTrue.Location = new Point(9, 47);
            radTrue.Name = "radTrue";
            radTrue.Size = new Size(69, 29);
            radTrue.TabIndex = 0;
            radTrue.TabStop = true;
            radTrue.Text = "True";
            radTrue.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(708, 349);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 11;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(847, 349);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 450);
            Controls.Add(btnSave);
            Controls.Add(btnReturn);
            Controls.Add(grBxIsAvailable);
            Controls.Add(cbxCategory);
            Controls.Add(txtBxPrice);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(lbUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProductForm";
            Text = "EditProductForm";
            grBxIsAvailable.ResumeLayout(false);
            grBxIsAvailable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbUserName;
        private TextBox txtBxID;
        private TextBox txtBxName;
        private TextBox txtBxPrice;
        private ComboBox cbxCategory;
        private GroupBox grBxIsAvailable;
        private RadioButton radFalse;
        private RadioButton radTrue;
        private Button btnReturn;
        private Button btnSave;
    }
}
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
            label6 = new Label();
            panel1 = new Panel();
            grBxIsAvailable.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(705, 185);
            label1.Name = "label1";
            label1.Size = new Size(40, 30);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(705, 280);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(705, 378);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(705, 481);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(705, 595);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 4;
            label5.Text = "isAvailable";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(21, 21);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(179, 38);
            lbUserName.TabIndex = 5;
            lbUserName.Text = "<username>";
            // 
            // txtBxID
            // 
            txtBxID.Location = new Point(871, 182);
            txtBxID.Name = "txtBxID";
            txtBxID.Size = new Size(371, 31);
            txtBxID.TabIndex = 6;
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(871, 277);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(371, 31);
            txtBxName.TabIndex = 7;
            // 
            // txtBxPrice
            // 
            txtBxPrice.Location = new Point(871, 372);
            txtBxPrice.Name = "txtBxPrice";
            txtBxPrice.Size = new Size(371, 31);
            txtBxPrice.TabIndex = 8;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(871, 473);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(234, 33);
            cbxCategory.TabIndex = 9;
            // 
            // grBxIsAvailable
            // 
            grBxIsAvailable.Controls.Add(radFalse);
            grBxIsAvailable.Controls.Add(radTrue);
            grBxIsAvailable.Location = new Point(871, 548);
            grBxIsAvailable.Name = "grBxIsAvailable";
            grBxIsAvailable.Size = new Size(242, 94);
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
            btnReturn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(75, 925);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(150, 75);
            btnReturn.TabIndex = 11;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(1074, 697);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 57);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 209);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 13;
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
            panel1.TabIndex = 14;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Controls.Add(grBxIsAvailable);
            Controls.Add(cbxCategory);
            Controls.Add(txtBxPrice);
            Controls.Add(txtBxName);
            Controls.Add(txtBxID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProductForm";
            Text = "EditProductForm";
            grBxIsAvailable.ResumeLayout(false);
            grBxIsAvailable.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label6;
        private Panel panel1;
    }
}